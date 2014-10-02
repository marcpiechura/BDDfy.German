using System;
using BDDfy.German.Scanners.StepScanners.Fluent;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.BDDfy;

namespace BDDfy.German.Samples
{
    [TestClass]
    [Story(
     AsA = "As an Account Holder",
     IWant = "I want to withdraw cash from an ATM",
     SoThat = "So that I can get money when the bank is closed")]
    public class FirstExampleTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            this.Angenommen(() =>
            {
                Value = 1;

            }, "Wert ist 1")
                .Wenn(() => Value += 2, "1 addiert wird")
                .Dann(() => Value.Should().Be(2), "soll der Wert 2 sein")
                .BDDfy("Test");

        }

        public int Value { get; set; }
    }
}
