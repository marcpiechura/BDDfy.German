using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;
using TestStack.BDDfy;
using TestStack.BDDfy.Configuration;

namespace BDDfy.German.Scanners.StepScanners.Fluent
{
    public class FluentGermanScanner<TScenario> : IFluentScanner where TScenario :class 
    {
        private readonly TScenario _storyObject;
        private readonly List<Step> _steps = new List<Step>();
        private readonly ITestContext _testContext;

        public FluentGermanScanner(object testObject, TScenario storyObject)
        {
            _storyObject = storyObject;
            _testContext = TestContext.GetContext(testObject);
        }

        public IScanner GetScanner(string scenarioTitle, Type explicitStoryType)
        {
            return new GermanScanner(_testContext, _storyObject, new FluentScenarioScanner(_steps, scenarioTitle), explicitStoryType);
        }

        public void AddStep(Action stepAction, string title, bool reports, ExecutionOrder executionOrder, bool asserts, string stepPrefix)
        {
            var action = StepActionFactory.GetStepAction<object>(o => stepAction());
            _steps.Add(new Step(action, new StepTitle(AppendPrefix(title, stepPrefix)), FixAsserts(asserts, executionOrder), FixConsecutiveStep(executionOrder), reports, new List<StepArgument>()));
        }

        public void AddStep(Func<Task> stepAction, string title, bool reports, ExecutionOrder executionOrder, bool asserts, string stepPrefix)
        {
            var action = StepActionFactory.GetStepAction<object>(o => stepAction());
            _steps.Add(new Step(action, new StepTitle(AppendPrefix(title, stepPrefix)), FixAsserts(asserts, executionOrder), FixConsecutiveStep(executionOrder), reports, new List<StepArgument>()));
        }

        public void AddStep(Expression<Func<TScenario, Task>> stepAction, string stepTextTemplate, bool includeInputsInStepTitle, bool reports, ExecutionOrder executionOrder, bool asserts, string stepPrefix)
        {
            var action = stepAction.Compile();
            var inputArguments = new StepArgument[0];
            if (includeInputsInStepTitle)
            {
                inputArguments = stepAction.ExtractArguments(_storyObject).ToArray();
            }

            var title = CreateTitle(stepTextTemplate, includeInputsInStepTitle, GetMethodInfo(stepAction), inputArguments, stepPrefix);
            var args = inputArguments.Where(s => !string.IsNullOrEmpty(s.Name)).ToList();
            _steps.Add(new Step(StepActionFactory.GetStepAction(action), title, FixAsserts(asserts, executionOrder), FixConsecutiveStep(executionOrder), reports, args));
        }

        public void AddStep(Expression<Action<TScenario>> stepAction, string stepTextTemplate, bool includeInputsInStepTitle, bool reports, ExecutionOrder executionOrder, bool asserts, string stepPrefix)
        {
            var action = stepAction.Compile();

            var inputArguments = new StepArgument[0];
            if (includeInputsInStepTitle)
            {
                inputArguments = stepAction.ExtractArguments(_storyObject).ToArray();
            }

            var title = CreateTitle(stepTextTemplate, includeInputsInStepTitle, GetMethodInfo(stepAction), inputArguments, stepPrefix);
            var args = inputArguments.Where(s => !string.IsNullOrEmpty(s.Name)).ToList();
            _steps.Add(new Step(StepActionFactory.GetStepAction(action), title, FixAsserts(asserts, executionOrder), FixConsecutiveStep(executionOrder), reports, args));
        }
        
        private string AppendPrefix(string title, string stepPrefix)
        {
            if (!title.StartsWith(stepPrefix, StringComparison.InvariantCultureIgnoreCase))
            {
                return string.Format("{0} {1}{2}", stepPrefix, title.Substring(0, 1).ToLower(), title.Substring(1));
            }

            return title;
        }

        private bool FixAsserts(bool asserts, ExecutionOrder executionOrder)
        {
            if (executionOrder == ExecutionOrder.ConsecutiveStep)
            {
                var lastStep = _steps.LastOrDefault();
                if (lastStep != null)
                {
                    return lastStep.Asserts;
                }
            }

            return asserts;
        }

        private ExecutionOrder FixConsecutiveStep(ExecutionOrder executionOrder)
        {
            if (executionOrder == ExecutionOrder.ConsecutiveStep)
            {
                var lastStep = _steps.LastOrDefault();
                if (lastStep != null)
                {
                    switch (lastStep.ExecutionOrder)
                    {
                        case ExecutionOrder.Initialize:
                        case ExecutionOrder.SetupState:
                        case ExecutionOrder.ConsecutiveSetupState:
                            return ExecutionOrder.ConsecutiveSetupState;
                        case ExecutionOrder.Transition:
                        case ExecutionOrder.ConsecutiveTransition:
                            return ExecutionOrder.ConsecutiveTransition;
                        case ExecutionOrder.Assertion:
                        case ExecutionOrder.ConsecutiveAssertion:
                        case ExecutionOrder.TearDown:
                            return ExecutionOrder.ConsecutiveAssertion;
                    }
                }
            }

            return executionOrder;
        }

        private StepTitle CreateTitle(string stepTextTemplate, bool includeInputsInStepTitle, MethodInfo methodInfo, StepArgument[] inputArguments, string stepPrefix)
        {
            Func<string> createTitle = () =>
            {

                var flatInputArray = inputArguments.Select(o => o.Value).FlattenArrays();
                var name = methodInfo.Name;
                var stepTitleAttribute = methodInfo.GetCustomAttributes(typeof(StepTitleAttribute), true).SingleOrDefault();
                if (stepTitleAttribute != null)
                {
                    var titleAttribute = ((StepTitleAttribute)stepTitleAttribute);
                    name = string.Format(titleAttribute.StepTitle, flatInputArray);
                    if (titleAttribute.IncludeInputsInStepTitle != null)
                        includeInputsInStepTitle = titleAttribute.IncludeInputsInStepTitle.Value;
                }

                var stepTitle = AppendPrefix(Configurator.Scanners.Humanize(name), stepPrefix);

                if (!string.IsNullOrEmpty(stepTextTemplate)) stepTitle = string.Format(stepTextTemplate, flatInputArray);
                else if (includeInputsInStepTitle)
                {
                    var parameters = methodInfo.GetParameters();
                    var stringFlatInputs =
                        inputArguments
                            .Select((a, i) => new { ParameterName = parameters[i].Name, Value = a })
                            .Select(i =>
                            {
                                if (_testContext.Examples != null)
                                {
                                    var matchingHeader = _testContext.Examples.Headers
                                        .SingleOrDefault(header => ExampleTable.HeaderMatches(header, i.ParameterName) ||
                                        ExampleTable.HeaderMatches(header, i.Value.Name));
                                    if (matchingHeader != null)
                                        return string.Format("<{0}>", matchingHeader);
                                }
                                return i.Value.Value.FlattenArray();
                            })
                            .ToArray();
                    stepTitle = stepTitle + " " + string.Join(", ", stringFlatInputs);
                }

                return stepTitle.Trim();
            };

            return new StepTitle(createTitle);
        }

        private static MethodInfo GetMethodInfo(Expression<Func<TScenario, Task>> stepAction)
        {
            var methodCall = (MethodCallExpression)stepAction.Body;
            return methodCall.Method;
        }

        private static MethodInfo GetMethodInfo(Expression<Action<TScenario>> stepAction)
        {
            var methodCall = (MethodCallExpression)stepAction.Body;
            return methodCall.Method;
        }
    }
}