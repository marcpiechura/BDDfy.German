using System;
using System.Collections.Generic;
using System.Linq;
using TestStack.BDDfy;

namespace BDDfy.German.Scanners.StepScanners.Fluent
{
    public class FluentGermanScanner : IFluentScanner
    {
        private readonly object _storyObject;
        private readonly List<Step> _steps = new List<Step>();
        private readonly ITestContext _testContext;

        public FluentGermanScanner(object testObject, object storyObject)
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
    }
}