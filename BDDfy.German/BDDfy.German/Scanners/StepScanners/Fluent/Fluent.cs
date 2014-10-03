using System;

namespace BDDfy.German.Scanners.StepScanners.Fluent
{
    public static class FluentGermanStepScannerExtensions
    {
        public static FluentGermanStepBuilder<TScenario> Angenommen<TScenario>(this TScenario testObject, Action step, string title)
            where TScenario : class
        {
            return new FluentGermanStepBuilder<TScenario>(testObject).Angenommen(step, title);
        }
    }
}
