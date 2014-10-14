using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BDDfy.German.Scanners.StepScanners.Fluent
{
    public static class FluentGermanStepScannerExtensions
    {
        #region Angenommen

        public static FluentGermanStepBuilder<TScenario> Angenommen<TScenario>(this TScenario testObject, Expression<Action<TScenario>> step, string stepTextTemplate)
            where TScenario : class
        {
            return new FluentGermanStepBuilder<TScenario>(testObject).Angenommen(step, stepTextTemplate);
        }

        public static FluentGermanStepBuilder<TScenario> Angenommen<TScenario>(this TScenario testObject, Expression<Action<TScenario>> step, bool includeInputsInStepTitle)
            where TScenario : class
        {
            return new FluentGermanStepBuilder<TScenario>(testObject).Angenommen(step, includeInputsInStepTitle);
        }

        public static FluentGermanStepBuilder<TScenario> Angenommen<TScenario>(this TScenario testObject, Expression<Action<TScenario>> step)
            where TScenario : class
        {
            return new FluentGermanStepBuilder<TScenario>(testObject).Angenommen(step);
        }

        public static FluentGermanStepBuilder<TScenario> Angenommen<TScenario>(this TScenario testObject, Expression<Func<TScenario, Task>> step, string stepTextTemplate)
            where TScenario : class
        {
            return new FluentGermanStepBuilder<TScenario>(testObject).Angenommen(step, stepTextTemplate);
        }

        public static FluentGermanStepBuilder<TScenario> Angenommen<TScenario>(this TScenario testObject, Expression<Func<TScenario, Task>> step, bool includeInputsInStepTitle)
            where TScenario : class
        {
            return new FluentGermanStepBuilder<TScenario>(testObject).Angenommen(step, includeInputsInStepTitle);
        }

        public static FluentGermanStepBuilder<TScenario> Angenommen<TScenario>(this TScenario testObject, Expression<Func<TScenario, Task>> step)
            where TScenario : class
        {
            return new FluentGermanStepBuilder<TScenario>(testObject).Angenommen(step);
        }

        public static FluentGermanStepBuilder<TScenario> Angenommen<TScenario>(this TScenario testObject, Action step, string title)
            where TScenario : class
        {
            return new FluentGermanStepBuilder<TScenario>(testObject).Angenommen(step, title);
        }

        public static FluentGermanStepBuilder<TScenario> Angenommen<TScenario>(this TScenario testObject, Func<Task> step, string title)
            where TScenario : class
        {
            return new FluentGermanStepBuilder<TScenario>(testObject).Angenommen(step, title);
        }

        public static FluentGermanStepBuilder<TScenario> Angenommen<TScenario>(this TScenario testObject, string title)
            where TScenario : class
        {
            return new FluentGermanStepBuilder<TScenario>(testObject).Angenommen(title);
        }

        #endregion

        #region Wenn
        
        public static FluentGermanStepBuilder<TScenario> Wenn<TScenario>(this TScenario testObject, Expression<Action<TScenario>> step, string stepTextTemplate)
            where TScenario : class
        {
            return new FluentGermanStepBuilder<TScenario>(testObject).Wenn(step, stepTextTemplate);
        }

        public static FluentGermanStepBuilder<TScenario> Wenn<TScenario>(this TScenario testObject, Expression<Action<TScenario>> step, bool includeInputsInStepTitle)
            where TScenario : class
        {
            return new FluentGermanStepBuilder<TScenario>(testObject).Wenn(step, includeInputsInStepTitle);
        }

        public static FluentGermanStepBuilder<TScenario> Wenn<TScenario>(this TScenario testObject, Expression<Action<TScenario>> step)
            where TScenario : class
        {
            return new FluentGermanStepBuilder<TScenario>(testObject).Wenn(step);
        }

        public static FluentGermanStepBuilder<TScenario> Wenn<TScenario>(this TScenario testObject, Expression<Func<TScenario, Task>> step, string stepTextTemplate)
            where TScenario : class
        {
            return new FluentGermanStepBuilder<TScenario>(testObject).Wenn(step, stepTextTemplate);
        }

        public static FluentGermanStepBuilder<TScenario> Wenn<TScenario>(this TScenario testObject, Expression<Func<TScenario, Task>> step, bool includeInputsInStepTitle)
            where TScenario : class
        {
            return new FluentGermanStepBuilder<TScenario>(testObject).Wenn(step, includeInputsInStepTitle);
        }

        public static FluentGermanStepBuilder<TScenario> Wenn<TScenario>(this TScenario testObject, Expression<Func<TScenario, Task>> step)
            where TScenario : class
        {
            return new FluentGermanStepBuilder<TScenario>(testObject).Wenn(step);
        }

        public static FluentGermanStepBuilder<TScenario> Wenn<TScenario>(this TScenario testObject, Action step, string title)
            where TScenario : class
        {
            return new FluentGermanStepBuilder<TScenario>(testObject).Wenn(step, title);
        }

        public static FluentGermanStepBuilder<TScenario> Wenn<TScenario>(this TScenario testObject, Func<Task> step, string title)
            where TScenario : class
        {
            return new FluentGermanStepBuilder<TScenario>(testObject).Wenn(step, title);
        }

        public static FluentGermanStepBuilder<TScenario> Wenn<TScenario>(this TScenario testObject, string title)
            where TScenario : class
        {
            return new FluentGermanStepBuilder<TScenario>(testObject).Wenn(title);
        }

        #endregion
    }
}
