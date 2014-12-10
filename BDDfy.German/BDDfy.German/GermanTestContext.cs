using System.Collections.Generic;
using TestStack.BDDfy;

namespace BDDfy.German
{
    class GermanTestContext : ITestContext
    {
        public GermanTestContext()
        {
            Tags = new List<string>();
        }

        public object TestObject { get; set; }
        public ExampleTable Examples { get; set; }
        public IFluentScanner FluentScanner { get; set; }
        public List<string> Tags { get; private set; }
    }
}
