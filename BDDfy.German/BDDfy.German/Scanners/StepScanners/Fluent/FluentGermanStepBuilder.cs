using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TestStack.BDDfy;

namespace BDDfy.German.Scanners.StepScanners.Fluent
{
    public class FluentGermanStepBuilder<TScenario> where TScenario : class
    {
        private readonly FluentGermanScanner<TScenario> _scanner;

        public FluentGermanStepBuilder(TScenario storyObject)
        {
            var existingContext = TestContext.GetContext(this);

            if (existingContext.FluentScanner == null)
                existingContext.FluentScanner = new FluentGermanScanner<TScenario>(this, storyObject);

            _scanner = (FluentGermanScanner<TScenario>)existingContext.FluentScanner;
        }

        #region Angenommen

        public FluentGermanStepBuilder<TScenario> Angenommen(Action step, string title)
        {
            _scanner.AddStep(step, title, true, ExecutionOrder.SetupState, false, "Angenommen");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Angenommen(Expression<Action<TScenario>> step, string stepTextTemplate)
        {
            _scanner.AddStep(step, stepTextTemplate, true, true, ExecutionOrder.SetupState, false, "Angenommen");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Angenommen(Expression<Action<TScenario>> step, bool includeInputsInStepTitle)
        {
            _scanner.AddStep(step, null, includeInputsInStepTitle, true, ExecutionOrder.SetupState, false, "Angenommen");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Angenommen(Expression<Action<TScenario>> step)
        {
            _scanner.AddStep(step, null, true, true, ExecutionOrder.SetupState, false, "Angenommen");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Angenommen(Expression<Func<TScenario, Task>> step, string stepTextTemplate)
        {
            _scanner.AddStep(step, stepTextTemplate, true, true, ExecutionOrder.SetupState, false, "Angenommen");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Angenommen(Expression<Func<TScenario, Task>> step, bool includeInputsInStepTitle)
        {
            _scanner.AddStep(step, null, includeInputsInStepTitle, true, ExecutionOrder.SetupState, false, "Angenommen");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Angenommen(Expression<Func<TScenario, Task>> step)
        {
            _scanner.AddStep(step, null, true, true, ExecutionOrder.SetupState, false, "Angenommen");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Angenommen(Func<Task> step, string title)
        {
            _scanner.AddStep(step, title, true, ExecutionOrder.SetupState, false, "Angenommen");
            return this;
        }


        public FluentGermanStepBuilder<TScenario> Angenommen(string title)
        {
            _scanner.AddStep(() => { }, title, true, ExecutionOrder.SetupState, false, "Angenommen");
            return this;
        }

        #endregion

        #region Wenn

        public FluentGermanStepBuilder<TScenario> Wenn(Expression<Action<TScenario>> step, string stepTextTemplate)
        {
            _scanner.AddStep(step, stepTextTemplate, true, true, ExecutionOrder.Transition, false, "Wenn");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Wenn(Expression<Action<TScenario>> step, bool includeInputsInStepTitle)
        {
            _scanner.AddStep(step, null, includeInputsInStepTitle, true, ExecutionOrder.Transition, false, "Wenn");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Wenn(Expression<Action<TScenario>> step)
        {
            _scanner.AddStep(step, null, true, true, ExecutionOrder.Transition, false, "Wenn");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Wenn(Expression<Func<TScenario, Task>> step, string stepTextTemplate)
        {
            _scanner.AddStep(step, stepTextTemplate, true, true, ExecutionOrder.Transition, false, "Wenn");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Wenn(Expression<Func<TScenario, Task>> step, bool includeInputsInStepTitle)
        {
            _scanner.AddStep(step, null, includeInputsInStepTitle, true, ExecutionOrder.Transition, false, "Wenn");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Wenn(Expression<Func<TScenario, Task>> step)
        {
            _scanner.AddStep(step, null, true, true, ExecutionOrder.Transition, false, "Wenn");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Wenn(Action step, string title)
        {
            _scanner.AddStep(step, title, true, ExecutionOrder.Transition, false, "Wenn");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Wenn(Func<Task> step, string title)
        {
            _scanner.AddStep(step, title, true, ExecutionOrder.Transition, false, "Wenn");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Wenn(string title)
        {
            _scanner.AddStep(() => { }, title, true, ExecutionOrder.Transition, false, "Wenn");
            return this;
        }

        #endregion

        #region Dann

        public FluentGermanStepBuilder<TScenario> Dann(Expression<Action<TScenario>> step, string stepTextTemplate)
        {
            _scanner.AddStep(step, stepTextTemplate, true, true, ExecutionOrder.Assertion, true, "Dann");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Dann(Expression<Action<TScenario>> step, bool includeInputsInStepTitle)
        {
            _scanner.AddStep(step, null, includeInputsInStepTitle, true, ExecutionOrder.Assertion, true, "Dann");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Dann(Expression<Action<TScenario>> step)
        {
            _scanner.AddStep(step, null, true, true, ExecutionOrder.Assertion, true, "Dann");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Dann(Expression<Func<TScenario, Task>> step, string stepTextTemplate)
        {
            _scanner.AddStep(step, stepTextTemplate, true, true, ExecutionOrder.Assertion, true, "Dann");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Dann(Expression<Func<TScenario, Task>> step, bool includeInputsInStepTitle)
        {
            _scanner.AddStep(step, null, includeInputsInStepTitle, true, ExecutionOrder.Assertion, true, "Dann");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Dann(Expression<Func<TScenario, Task>> step)
        {
            _scanner.AddStep(step, null, true, true, ExecutionOrder.Assertion, true, "Dann");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Dann(Action step, string title)
        {
            _scanner.AddStep(step, title, true, ExecutionOrder.Assertion, true, "Dann");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Dann(Func<Task> step, string title)
        {
            _scanner.AddStep(step, title, true, ExecutionOrder.Assertion, true, "Dann");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Dann(string title)
        {
            _scanner.AddStep(() => { }, title, true, ExecutionOrder.Assertion, true, "Dann");
            return this;
        }

        #endregion

        #region Und

        public FluentGermanStepBuilder<TScenario> Und(Expression<Action<TScenario>> step, string stepTextTemplate)
        {
            _scanner.AddStep(step, stepTextTemplate, true, true, ExecutionOrder.ConsecutiveStep, false, "Und");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Und(Expression<Action<TScenario>> step, bool includeInputsInStepTitle)
        {
            _scanner.AddStep(step, null, includeInputsInStepTitle, true, ExecutionOrder.ConsecutiveStep, false, "Und");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Und(Expression<Action<TScenario>> step)
        {
            _scanner.AddStep(step, null, true, true, ExecutionOrder.ConsecutiveStep, false, "Und");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Und(Expression<Func<TScenario, Task>> step, string stepTextTemplate)
        {
            _scanner.AddStep(step, stepTextTemplate, true, true, ExecutionOrder.ConsecutiveStep, false, "Und");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Und(Expression<Func<TScenario, Task>> step, bool includeInputsInStepTitle)
        {
            _scanner.AddStep(step, null, includeInputsInStepTitle, true, ExecutionOrder.ConsecutiveStep, false, "Und");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Und(Expression<Func<TScenario, Task>> step)
        {
            _scanner.AddStep(step, null, true, true, ExecutionOrder.ConsecutiveStep, false, "Und");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Und(Action step, string title)
        {
            _scanner.AddStep(step, title, true, ExecutionOrder.ConsecutiveStep, false, "Und");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Und(Func<Task> step, string title)
        {
            _scanner.AddStep(step, title, true, ExecutionOrder.ConsecutiveStep, false, "Und");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Und(string title)
        {
            _scanner.AddStep(() => { }, title, true, ExecutionOrder.ConsecutiveStep, false, "Und");
            return this;
        }

        #endregion

        #region Aber

        public FluentGermanStepBuilder<TScenario> Aber(Expression<Action<TScenario>> step, string stepTextTemplate)
        {
            _scanner.AddStep(step, stepTextTemplate, true, true, ExecutionOrder.ConsecutiveStep, false, "Aber");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Aber(Expression<Action<TScenario>> step, bool includeInputsInStepTitle)
        {
            _scanner.AddStep(step, null, includeInputsInStepTitle, true, ExecutionOrder.ConsecutiveStep, false, "Aber");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Aber(Expression<Action<TScenario>> step)
        {
            _scanner.AddStep(step, null, true, true, ExecutionOrder.ConsecutiveStep, false, "Aber");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Aber(Expression<Func<TScenario, Task>> step, string stepTextTemplate)
        {
            _scanner.AddStep(step, stepTextTemplate, true, true, ExecutionOrder.ConsecutiveStep, false, "Aber");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Aber(Expression<Func<TScenario, Task>> step, bool includeInputsInStepTitle)
        {
            _scanner.AddStep(step, null, includeInputsInStepTitle, true, ExecutionOrder.ConsecutiveStep, false, "Aber");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Aber(Expression<Func<TScenario, Task>> step)
        {
            _scanner.AddStep(step, null, true, true, ExecutionOrder.ConsecutiveStep, false, "Aber");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Aber(Action step, string title)
        {
            _scanner.AddStep(step, title, true, ExecutionOrder.ConsecutiveStep, false, "Aber");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Aber(Func<Task> step, string title)
        {
            _scanner.AddStep(step, title, true, ExecutionOrder.ConsecutiveStep, false, "Aber");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Aber(string title)
        {
            _scanner.AddStep(() => { }, title, true, ExecutionOrder.ConsecutiveStep, false, "Aber");
            return this;
        }

        #endregion

        #region BeendenMit

        public FluentGermanStepBuilder<TScenario> BeendenMit(Expression<Action<TScenario>> step, string stepTextTemplate)
        {
            _scanner.AddStep(step, stepTextTemplate, true, false, ExecutionOrder.TearDown, false, "");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> BeendenMit(Expression<Action<TScenario>> step, bool includeInputsInStepTitle)
        {
            _scanner.AddStep(step, null, includeInputsInStepTitle, false, ExecutionOrder.TearDown, false, "");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> BeendenMit(Expression<Action<TScenario>> step)
        {
            _scanner.AddStep(step, null, true, false, ExecutionOrder.TearDown, false, "");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> BeendenMit(Expression<Func<TScenario, Task>> step, string stepTextTemplate)
        {
            _scanner.AddStep(step, stepTextTemplate, true, false, ExecutionOrder.TearDown, false, "");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> BeendenMit(Expression<Func<TScenario, Task>> step, bool includeInputsInStepTitle)
        {
            _scanner.AddStep(step, null, includeInputsInStepTitle, false, ExecutionOrder.TearDown, false, "");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> BeendenMit(Expression<Func<TScenario, Task>> step)
        {
            _scanner.AddStep(step, null, true, false, ExecutionOrder.TearDown, false, "");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> BeendenMit(Action step, string title)
        {
            _scanner.AddStep(step, title, false, ExecutionOrder.TearDown, false, "");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> BeendenMit(Func<Task> step, string title)
        {
            _scanner.AddStep(step, title, false, ExecutionOrder.TearDown, false, "");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> BeendenMit(string title)
        {
            _scanner.AddStep(() => { }, title, false, ExecutionOrder.TearDown, false, "");
            return this;
        }

        #endregion

        public FluentGermanStepBuilder<TScenario> Quelle(string title)
        {
            _scanner.AddStep(() => {}, title, false, ExecutionOrder.Initialize, false, "Quelle");
            return this;
        }
    }
}