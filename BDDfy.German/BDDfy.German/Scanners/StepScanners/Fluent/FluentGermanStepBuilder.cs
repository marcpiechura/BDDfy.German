﻿using System;
using TestStack.BDDfy;

namespace BDDfy.German.Scanners.StepScanners.Fluent
{
    public class FluentGermanStepBuilder<TScenario> where TScenario : class
    {
        private readonly FluentGermanScanner _scanner;

        public FluentGermanStepBuilder(TScenario storyObject)
        {
            var existingContext = TestContext.GetContext(this);

            if (existingContext.FluentScanner == null)
                existingContext.FluentScanner = new FluentGermanScanner(this, storyObject);

            _scanner = (FluentGermanScanner)existingContext.FluentScanner;
        }

        public FluentGermanStepBuilder<TScenario> Angenommen(Action step, string title)
        {
            _scanner.AddStep(step, title, true, ExecutionOrder.SetupState, false, "Angenommen");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Wenn(Action step, string title)
        {
            _scanner.AddStep(step, title, true, ExecutionOrder.Transition, false, "Wenn");
            return this;
        }

        public FluentGermanStepBuilder<TScenario> Dann(Action step, string title)
        {
            _scanner.AddStep(step, title, true, ExecutionOrder.Assertion, false, "Dann");
            return this;
        }
    }
}