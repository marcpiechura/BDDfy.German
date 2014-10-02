using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TestStack.BDDfy;

namespace BDDfy.German.Scanners.StepScanners.Fluent
{
    public static class FluentStepScannerExtensions
    {
        public static IFluentStepBuilder<TScenario> Angenommen<TScenario>(this TScenario testObject, Expression<Action<TScenario>> step, string stepTextTemplate)
            where TScenario : class
        {
            return new FluentGermanStepBuilder<TScenario>(testObject).Angenommen(step, stepTextTemplate);
        }

        public static IFluentStepBuilder<TScenario> Angenommen<TScenario>(this TScenario testObject, Expression<Action<TScenario>> step, bool includeInputsInStepTitle)
            where TScenario : class
        {
            return new FluentGermanStepBuilder<TScenario>(testObject).Angenommen(step, includeInputsInStepTitle);
        }

        public static IFluentStepBuilder<TScenario> Angenommen<TScenario>(this TScenario testObject, Expression<Action<TScenario>> step)
            where TScenario : class
        {
            return new FluentGermanStepBuilder<TScenario>(testObject).Angenommen(step);
        }

        public static IFluentStepBuilder<TScenario> Angenommen<TScenario>(this TScenario testObject, Expression<Func<TScenario, Task>> step, string stepTextTemplate)
            where TScenario : class
        {
            return new FluentGermanStepBuilder<TScenario>(testObject).Angenommen(step, stepTextTemplate);
        }

        public static IFluentStepBuilder<TScenario> Angenommen<TScenario>(this TScenario testObject, Expression<Func<TScenario, Task>> step, bool includeInputsInStepTitle)
            where TScenario : class
        {
            return new FluentGermanStepBuilder<TScenario>(testObject).Angenommen(step, includeInputsInStepTitle);
        }

        public static IFluentStepBuilder<TScenario> Angenommen<TScenario>(this TScenario testObject, Expression<Func<TScenario, Task>> step)
            where TScenario : class
        {
            return new FluentGermanStepBuilder<TScenario>(testObject).Angenommen(step);
        }

        public static IFluentStepBuilder<TScenario> Angenommen<TScenario>(this TScenario testObject, Action step, string title)
            where TScenario : class
        {
            return new FluentGermanStepBuilder<TScenario>(testObject).Angenommen(step, title);
        }

        public static IFluentStepBuilder<TScenario> Angenommen<TScenario>(this TScenario testObject, Func<Task> step, string title)
            where TScenario : class
        {
            return new FluentGermanStepBuilder<TScenario>(testObject).Angenommen(step, title);
        }

        public static IFluentStepBuilder<TScenario> Angenommen<TScenario>(this TScenario testObject, string title)
            where TScenario : class
        {
            return new FluentGermanStepBuilder<TScenario>(testObject).Angenommen(title);
        }

        public static IFluentStepBuilder<TScenario> Wenn<TScenario>(this TScenario testObject, Expression<Action<TScenario>> step, string stepTextTemplate)
            where TScenario : class
        {
            return new FluentGermanStepBuilder<TScenario>(testObject).Wenn(step, stepTextTemplate);
        }

        public static IFluentStepBuilder<TScenario> Wenn<TScenario>(this TScenario testObject, Expression<Action<TScenario>> step, bool includeInputsInStepTitle)
            where TScenario : class
        {
            return new FluentGermanStepBuilder<TScenario>(testObject).Wenn(step, includeInputsInStepTitle);
        }

        public static IFluentStepBuilder<TScenario> Wenn<TScenario>(this TScenario testObject, Expression<Action<TScenario>> step)
            where TScenario : class
        {
            return new FluentGermanStepBuilder<TScenario>(testObject).Wenn(step);
        }

        public static IFluentStepBuilder<TScenario> Wenn<TScenario>(this TScenario testObject, Expression<Func<TScenario, Task>> step, string stepTextTemplate)
            where TScenario : class
        {
            return new FluentGermanStepBuilder<TScenario>(testObject).Wenn(step, stepTextTemplate);
        }

        public static IFluentStepBuilder<TScenario> Wenn<TScenario>(this TScenario testObject, Expression<Func<TScenario, Task>> step, bool includeInputsInStepTitle)
            where TScenario : class
        {
            return new FluentGermanStepBuilder<TScenario>(testObject).Wenn(step, includeInputsInStepTitle);
        }

        public static IFluentStepBuilder<TScenario> Wenn<TScenario>(this TScenario testObject, Expression<Func<TScenario, Task>> step)
            where TScenario : class
        {
            return new FluentGermanStepBuilder<TScenario>(testObject).Wenn(step);
        }

        public static IFluentStepBuilder<TScenario> Wenn<TScenario>(this TScenario testObject, Action step, string title)
            where TScenario : class
        {
            return new FluentGermanStepBuilder<TScenario>(testObject).Wenn(step, title);
        }

        public static IFluentStepBuilder<TScenario> Wenn<TScenario>(this TScenario testObject, Func<Task> step, string title)
            where TScenario : class
        {
            return new FluentGermanStepBuilder<TScenario>(testObject).Wenn(step, title);
        }

        public static IFluentStepBuilder<TScenario> Wenn<TScenario>(this TScenario testObject, string title)
            where TScenario : class
        {
            return new FluentGermanStepBuilder<TScenario>(testObject).Wenn(title);
        }
    }

    public interface IFluentGermanStepBuilder<TScenario> where TScenario : class
    {
        TScenario TestObject { get; }

        IFluentStepBuilder<TScenario> Angenommen(Expression<Action<TScenario>> step, string stepTextTemplate);

        IFluentStepBuilder<TScenario> Angenommen(Expression<Action<TScenario>> step, bool includeInputsInStepTitle);

        IFluentStepBuilder<TScenario> Angenommen(Expression<Action<TScenario>> step);

        IFluentStepBuilder<TScenario> Angenommen(Expression<Func<TScenario, Task>> step, string stepTextTemplate);

        IFluentStepBuilder<TScenario> Angenommen(Expression<Func<TScenario, Task>> step, bool includeInputsInStepTitle);

        IFluentStepBuilder<TScenario> Angenommen(Expression<Func<TScenario, Task>> step);

        IFluentStepBuilder<TScenario> Angenommen(Action step, string title);

        IFluentStepBuilder<TScenario> Angenommen(Func<Task> step, string title);

        IFluentStepBuilder<TScenario> Angenommen(string title);

        IFluentStepBuilder<TScenario> Wenn(Expression<Action<TScenario>> step, string stepTextTemplate);

        IFluentStepBuilder<TScenario> Wenn(Expression<Action<TScenario>> step, bool includeInputsInStepTitle);

        IFluentStepBuilder<TScenario> Wenn(Expression<Action<TScenario>> step);

        IFluentStepBuilder<TScenario> Wenn(Expression<Func<TScenario, Task>> step, string stepTextTemplate);

        IFluentStepBuilder<TScenario> Wenn(Expression<Func<TScenario, Task>> step, bool includeInputsInStepTitle);

        IFluentStepBuilder<TScenario> Wenn(Expression<Func<TScenario, Task>> step);

        IFluentStepBuilder<TScenario> Wenn(Action step, string title);

        IFluentStepBuilder<TScenario> Wenn(Func<Task> step, string title);

        IFluentStepBuilder<TScenario> Wenn(string title);

        IFluentStepBuilder<TScenario> Dann(Expression<Action<TScenario>> step, string stepTextTemplate);

        IFluentStepBuilder<TScenario> Dann(Expression<Action<TScenario>> step, bool includeInputsInStepTitle);

        IFluentStepBuilder<TScenario> Dann(Expression<Action<TScenario>> step);

        IFluentStepBuilder<TScenario> Dann(Expression<Func<TScenario, Task>> step, string stepTextTemplate);

        IFluentStepBuilder<TScenario> Dann(Expression<Func<TScenario, Task>> step, bool includeInputsInStepTitle);

        IFluentStepBuilder<TScenario> Dann(Expression<Func<TScenario, Task>> step);

        IFluentStepBuilder<TScenario> Dann(Action step, string title);

        IFluentStepBuilder<TScenario> Dann(Func<Task> step, string title);

        IFluentStepBuilder<TScenario> Dann(string title);

        IFluentStepBuilder<TScenario> Und(Expression<Action<TScenario>> step, string stepTextTemplate);

        IFluentStepBuilder<TScenario> Und(Expression<Action<TScenario>> step, bool includeInputsInStepTitle);

        IFluentStepBuilder<TScenario> Und(Expression<Action<TScenario>> step);

        IFluentStepBuilder<TScenario> Und(Expression<Func<TScenario, Task>> step, string stepTextTemplate);

        IFluentStepBuilder<TScenario> Und(Expression<Func<TScenario, Task>> step, bool includeInputsInStepTitle);

        IFluentStepBuilder<TScenario> Und(Expression<Func<TScenario, Task>> step);

        IFluentStepBuilder<TScenario> Und(Action step, string title);

        IFluentStepBuilder<TScenario> Und(Func<Task> step, string title);

        IFluentStepBuilder<TScenario> Und(string title);

        IFluentStepBuilder<TScenario> Aber(Expression<Action<TScenario>> step, string stepTextTemplate);

        IFluentStepBuilder<TScenario> Aber(Expression<Action<TScenario>> step, bool includeInputsInStepTitle);

        IFluentStepBuilder<TScenario> Aber(Expression<Action<TScenario>> step);

        IFluentStepBuilder<TScenario> Aber(Expression<Func<TScenario, Task>> step, string stepTextTemplate);

        IFluentStepBuilder<TScenario> Aber(Expression<Func<TScenario, Task>> step, bool includeInputsInStepTitle);

        IFluentStepBuilder<TScenario> Aber(Expression<Func<TScenario, Task>> step);

        IFluentStepBuilder<TScenario> Aber(Action step, string title);

        IFluentStepBuilder<TScenario> Aber(Func<Task> step, string title);

        IFluentStepBuilder<TScenario> Aber(string title);

        IFluentStepBuilder<TScenario> BeendenMit(Expression<Action<TScenario>> step, string stepTextTemplate);

        IFluentStepBuilder<TScenario> BeendenMit(Expression<Action<TScenario>> step, bool includeInputsInStepTitle);

        IFluentStepBuilder<TScenario> BeendenMit(Expression<Action<TScenario>> step);

        IFluentStepBuilder<TScenario> BeendenMit(Expression<Func<TScenario, Task>> step, string stepTextTemplate);

        IFluentStepBuilder<TScenario> BeendenMit(Expression<Func<TScenario, Task>> step, bool includeInputsInStepTitle);

        IFluentStepBuilder<TScenario> BeendenMit(Expression<Func<TScenario, Task>> step);

        IFluentStepBuilder<TScenario> BeendenMit(Action step, string title);

        IFluentStepBuilder<TScenario> BeendenMit(Func<Task> step, string title);

        IFluentStepBuilder<TScenario> BeendenMit(string title);
    }

    interface IFluentGermanStepBuilder
    {
        object TestObject { get; }
    }

    public class FluentGermanStepBuilder<TScenario> : IFluentGermanStepBuilder<TScenario>, IFluentGermanStepBuilder
                                                where TScenario : class
    {
        readonly FluentGermanScanner<TScenario> scanner;

        public FluentGermanStepBuilder(TScenario testObject)
        {
            TestObject = testObject;
            var existingContext = TestContext.GetContext(TestObject);
            if (existingContext.FluentScanner == null)
                existingContext.FluentScanner = new FluentGermanScanner<TScenario>(testObject);

            scanner = (FluentGermanScanner<TScenario>)existingContext.FluentScanner;
        }

        public TScenario TestObject { get; private set; }

        object IFluentGermanStepBuilder.TestObject { get { return TestObject; } }

        public IFluentStepBuilder<TScenario> Angenommen(Expression<Action<TScenario>> step, string stepTextTemplate)
        {
            scanner.AddStep(step, stepTextTemplate, true, true, ExecutionOrder.SetupState, false, "Angenommen");
            return this;
        }

        public IFluentStepBuilder<TScenario> Angenommen(Expression<Action<TScenario>> step, bool includeInputsInStepTitle)
        {
            scanner.AddStep(step, null, includeInputsInStepTitle, true, ExecutionOrder.SetupState, false, "Angenommen");
            return this;
        }

        public IFluentStepBuilder<TScenario> Angenommen(Expression<Action<TScenario>> step)
        {
            scanner.AddStep(step, null, true, true, ExecutionOrder.SetupState, false, "Angenommen");
            return this;
        }

        public IFluentStepBuilder<TScenario> Angenommen(Expression<Func<TScenario, Task>> step, string stepTextTemplate)
        {
            scanner.AddStep(step, stepTextTemplate, true, true, ExecutionOrder.SetupState, false, "Angenommen");
            return this;
        }

        public IFluentStepBuilder<TScenario> Angenommen(Expression<Func<TScenario, Task>> step, bool includeInputsInStepTitle)
        {
            scanner.AddStep(step, null, includeInputsInStepTitle, true, ExecutionOrder.SetupState, false, "Angenommen");
            return this;
        }

        public IFluentStepBuilder<TScenario> Angenommen(Expression<Func<TScenario, Task>> step)
        {
            scanner.AddStep(step, null, true, true, ExecutionOrder.SetupState, false, "Angenommen");
            return this;
        }

        public IFluentStepBuilder<TScenario> Angenommen(Action step, string title)
        {
            scanner.AddStep(step, title, true, ExecutionOrder.SetupState, false, "Angenommen");
            return this;
        }

        public IFluentStepBuilder<TScenario> Angenommen(Func<Task> step, string title)
        {
            scanner.AddStep(step, title, true, ExecutionOrder.SetupState, false, "Angenommen");
            return this;
        }

        public IFluentStepBuilder<TScenario> Angenommen(string title)
        {
            scanner.AddStep(() => { }, title, true, ExecutionOrder.SetupState, false, "Angenommen");
            return this;
        }
        public IFluentStepBuilder<TScenario> Wenn(Expression<Action<TScenario>> step, string stepTextTemplate)
        {
            scanner.AddStep(step, stepTextTemplate, true, true, ExecutionOrder.Transition, false, "Wenn");
            return this;
        }

        public IFluentStepBuilder<TScenario> Wenn(Expression<Action<TScenario>> step, bool includeInputsInStepTitle)
        {
            scanner.AddStep(step, null, includeInputsInStepTitle, true, ExecutionOrder.Transition, false, "Wenn");
            return this;
        }

        public IFluentStepBuilder<TScenario> Wenn(Expression<Action<TScenario>> step)
        {
            scanner.AddStep(step, null, true, true, ExecutionOrder.Transition, false, "Wenn");
            return this;
        }

        public IFluentStepBuilder<TScenario> Wenn(Expression<Func<TScenario, Task>> step, string stepTextTemplate)
        {
            scanner.AddStep(step, stepTextTemplate, true, true, ExecutionOrder.Transition, false, "Wenn");
            return this;
        }

        public IFluentStepBuilder<TScenario> Wenn(Expression<Func<TScenario, Task>> step, bool includeInputsInStepTitle)
        {
            scanner.AddStep(step, null, includeInputsInStepTitle, true, ExecutionOrder.Transition, false, "Wenn");
            return this;
        }

        public IFluentStepBuilder<TScenario> Wenn(Expression<Func<TScenario, Task>> step)
        {
            scanner.AddStep(step, null, true, true, ExecutionOrder.Transition, false, "Wenn");
            return this;
        }

        public IFluentStepBuilder<TScenario> Wenn(Action step, string title)
        {
            scanner.AddStep(step, title, true, ExecutionOrder.Transition, false, "Wenn");
            return this;
        }

        public IFluentStepBuilder<TScenario> Wenn(Func<Task> step, string title)
        {
            scanner.AddStep(step, title, true, ExecutionOrder.Transition, false, "Wenn");
            return this;
        }

        public IFluentStepBuilder<TScenario> Wenn(string title)
        {
            scanner.AddStep(() => { }, title, true, ExecutionOrder.Transition, false, "Wenn");
            return this;
        }
        public IFluentStepBuilder<TScenario> Dann(Expression<Action<TScenario>> step, string stepTextTemplate)
        {
            scanner.AddStep(step, stepTextTemplate, true, true, ExecutionOrder.Assertion, true, "Dann");
            return this;
        }

        public IFluentStepBuilder<TScenario> Dann(Expression<Action<TScenario>> step, bool includeInputsInStepTitle)
        {
            scanner.AddStep(step, null, includeInputsInStepTitle, true, ExecutionOrder.Assertion, true, "Dann");
            return this;
        }

        public IFluentStepBuilder<TScenario> Dann(Expression<Action<TScenario>> step)
        {
            scanner.AddStep(step, null, true, true, ExecutionOrder.Assertion, true, "Dann");
            return this;
        }

        public IFluentStepBuilder<TScenario> Dann(Expression<Func<TScenario, Task>> step, string stepTextTemplate)
        {
            scanner.AddStep(step, stepTextTemplate, true, true, ExecutionOrder.Assertion, true, "Dann");
            return this;
        }

        public IFluentStepBuilder<TScenario> Dann(Expression<Func<TScenario, Task>> step, bool includeInputsInStepTitle)
        {
            scanner.AddStep(step, null, includeInputsInStepTitle, true, ExecutionOrder.Assertion, true, "Dann");
            return this;
        }

        public IFluentStepBuilder<TScenario> Dann(Expression<Func<TScenario, Task>> step)
        {
            scanner.AddStep(step, null, true, true, ExecutionOrder.Assertion, true, "Dann");
            return this;
        }

        public IFluentStepBuilder<TScenario> Dann(Action step, string title)
        {
            scanner.AddStep(step, title, true, ExecutionOrder.Assertion, true, "Dann");
            return this;
        }

        public IFluentStepBuilder<TScenario> Dann(Func<Task> step, string title)
        {
            scanner.AddStep(step, title, true, ExecutionOrder.Assertion, true, "Dann");
            return this;
        }

        public IFluentStepBuilder<TScenario> Dann(string title)
        {
            scanner.AddStep(() => { }, title, true, ExecutionOrder.Assertion, true, "Dann");
            return this;
        }
        public IFluentStepBuilder<TScenario> Und(Expression<Action<TScenario>> step, string stepTextTemplate)
        {
            scanner.AddStep(step, stepTextTemplate, true, true, ExecutionOrder.ConsecutiveStep, false, "Und");
            return this;
        }

        public IFluentStepBuilder<TScenario> Und(Expression<Action<TScenario>> step, bool includeInputsInStepTitle)
        {
            scanner.AddStep(step, null, includeInputsInStepTitle, true, ExecutionOrder.ConsecutiveStep, false, "Und");
            return this;
        }

        public IFluentStepBuilder<TScenario> Und(Expression<Action<TScenario>> step)
        {
            scanner.AddStep(step, null, true, true, ExecutionOrder.ConsecutiveStep, false, "Und");
            return this;
        }

        public IFluentStepBuilder<TScenario> Und(Expression<Func<TScenario, Task>> step, string stepTextTemplate)
        {
            scanner.AddStep(step, stepTextTemplate, true, true, ExecutionOrder.ConsecutiveStep, false, "Und");
            return this;
        }

        public IFluentStepBuilder<TScenario> Und(Expression<Func<TScenario, Task>> step, bool includeInputsInStepTitle)
        {
            scanner.AddStep(step, null, includeInputsInStepTitle, true, ExecutionOrder.ConsecutiveStep, false, "Und");
            return this;
        }

        public IFluentStepBuilder<TScenario> Und(Expression<Func<TScenario, Task>> step)
        {
            scanner.AddStep(step, null, true, true, ExecutionOrder.ConsecutiveStep, false, "Und");
            return this;
        }

        public IFluentStepBuilder<TScenario> Und(Action step, string title)
        {
            scanner.AddStep(step, title, true, ExecutionOrder.ConsecutiveStep, false, "Und");
            return this;
        }

        public IFluentStepBuilder<TScenario> Und(Func<Task> step, string title)
        {
            scanner.AddStep(step, title, true, ExecutionOrder.ConsecutiveStep, false, "Und");
            return this;
        }

        public IFluentStepBuilder<TScenario> Und(string title)
        {
            scanner.AddStep(() => { }, title, true, ExecutionOrder.ConsecutiveStep, false, "Und");
            return this;
        }
        public IFluentStepBuilder<TScenario> Aber(Expression<Action<TScenario>> step, string stepTextTemplate)
        {
            scanner.AddStep(step, stepTextTemplate, true, true, ExecutionOrder.ConsecutiveStep, false, "Aber");
            return this;
        }

        public IFluentStepBuilder<TScenario> Aber(Expression<Action<TScenario>> step, bool includeInputsInStepTitle)
        {
            scanner.AddStep(step, null, includeInputsInStepTitle, true, ExecutionOrder.ConsecutiveStep, false, "Aber");
            return this;
        }

        public IFluentStepBuilder<TScenario> Aber(Expression<Action<TScenario>> step)
        {
            scanner.AddStep(step, null, true, true, ExecutionOrder.ConsecutiveStep, false, "Aber");
            return this;
        }

        public IFluentStepBuilder<TScenario> Aber(Expression<Func<TScenario, Task>> step, string stepTextTemplate)
        {
            scanner.AddStep(step, stepTextTemplate, true, true, ExecutionOrder.ConsecutiveStep, false, "Aber");
            return this;
        }

        public IFluentStepBuilder<TScenario> Aber(Expression<Func<TScenario, Task>> step, bool includeInputsInStepTitle)
        {
            scanner.AddStep(step, null, includeInputsInStepTitle, true, ExecutionOrder.ConsecutiveStep, false, "Aber");
            return this;
        }

        public IFluentStepBuilder<TScenario> Aber(Expression<Func<TScenario, Task>> step)
        {
            scanner.AddStep(step, null, true, true, ExecutionOrder.ConsecutiveStep, false, "Aber");
            return this;
        }

        public IFluentStepBuilder<TScenario> Aber(Action step, string title)
        {
            scanner.AddStep(step, title, true, ExecutionOrder.ConsecutiveStep, false, "Aber");
            return this;
        }

        public IFluentStepBuilder<TScenario> Aber(Func<Task> step, string title)
        {
            scanner.AddStep(step, title, true, ExecutionOrder.ConsecutiveStep, false, "Aber");
            return this;
        }

        public IFluentStepBuilder<TScenario> Aber(string title)
        {
            scanner.AddStep(() => { }, title, true, ExecutionOrder.ConsecutiveStep, false, "Aber");
            return this;
        }
        public IFluentStepBuilder<TScenario> BeendenMit(Expression<Action<TScenario>> step, string stepTextTemplate)
        {
            scanner.AddStep(step, stepTextTemplate, true, false, ExecutionOrder.TearDown, false, "");
            return this;
        }

        public IFluentStepBuilder<TScenario> BeendenMit(Expression<Action<TScenario>> step, bool includeInputsInStepTitle)
        {
            scanner.AddStep(step, null, includeInputsInStepTitle, false, ExecutionOrder.TearDown, false, "");
            return this;
        }

        public IFluentStepBuilder<TScenario> BeendenMit(Expression<Action<TScenario>> step)
        {
            scanner.AddStep(step, null, true, false, ExecutionOrder.TearDown, false, "");
            return this;
        }

        public IFluentStepBuilder<TScenario> BeendenMit(Expression<Func<TScenario, Task>> step, string stepTextTemplate)
        {
            scanner.AddStep(step, stepTextTemplate, true, false, ExecutionOrder.TearDown, false, "");
            return this;
        }

        public IFluentStepBuilder<TScenario> BeendenMit(Expression<Func<TScenario, Task>> step, bool includeInputsInStepTitle)
        {
            scanner.AddStep(step, null, includeInputsInStepTitle, false, ExecutionOrder.TearDown, false, "");
            return this;
        }

        public IFluentStepBuilder<TScenario> BeendenMit(Expression<Func<TScenario, Task>> step)
        {
            scanner.AddStep(step, null, true, false, ExecutionOrder.TearDown, false, "");
            return this;
        }

        public IFluentStepBuilder<TScenario> BeendenMit(Action step, string title)
        {
            scanner.AddStep(step, title, false, ExecutionOrder.TearDown, false, "");
            return this;
        }

        public IFluentStepBuilder<TScenario> BeendenMit(Func<Task> step, string title)
        {
            scanner.AddStep(step, title, false, ExecutionOrder.TearDown, false, "");
            return this;
        }

        public IFluentStepBuilder<TScenario> BeendenMit(string title)
        {
            scanner.AddStep(() => { }, title, false, ExecutionOrder.TearDown, false, "");
            return this;
        }
    }
}