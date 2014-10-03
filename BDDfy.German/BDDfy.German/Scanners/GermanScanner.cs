using System;
using System.Linq;
using TestStack.BDDfy;
using TestStack.BDDfy.Configuration;

namespace BDDfy.German.Scanners
{
    public class GermanScanner : IScanner
    {
        private readonly ITestContext _testContext;
        private readonly object _storyObject;
        private readonly Type _explicitStoryType;
        private readonly IScenarioScanner _scenarioScanner;

        public GermanScanner(ITestContext testContext, object storyObject, IScenarioScanner scenarioScanner, Type explicitStoryType = null)
        {
            _testContext = testContext;
            _storyObject = storyObject;
            _explicitStoryType = explicitStoryType;
            _scenarioScanner = scenarioScanner;   
        }

        public Story Scan()
        {
            var scenarios = _scenarioScanner.Scan(_testContext);
            var metaData = Configurator.Scanners.StoryMetadataScanner().Scan(_storyObject, _explicitStoryType);

            return new Story(metaData, scenarios.ToArray());
        }
    }
}