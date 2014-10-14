using System;
using BDDfy.German.Reporters.Html;
using BDDfy.German.Scanners.StepScanners.Fluent;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.BDDfy;
using TestStack.BDDfy.Configuration;
using TestStack.BDDfy.Reporters.Html;

namespace BDDfy.German.Samples
{
    [TestClass]
    [GermanStory(
        AlsEin = "Als ein Mathematiker", WillIch = "Additionen durchführen können",
        Damit = "Ich nicht alles im Kopf berechnen muss",
        Title = "Additionen berechnen")]
    public class FirstExampleTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Configurator.BatchProcessors.Add(new HtmlReporter(new ClassicGermanReportBuilder()));
            Configurator.BatchProcessors.HtmlReport.Disable();


            this.Angenommen(() => Value = 1, "Angenommen der Wert ist 1")
                .Wenn(() => Value++, "Der Wert um 1 erhört wird")
                .Und(() => Value2 = 1, "Und ein zweiter Wert auf 1 gesetzt wird")
                .Dann(() => Value.Should().Be(2), "Soll der Wert 2 sein")
                .Aber(() => Value--, "Aber der Wert kann auch mit 1 subtrahiert werden")
                .Und(() => Value2.Should().Be(1), "der zweite Wert soll 1 sein")
                .Quelle("Kunde xyz")
                .BeendenMit(() =>
                {
                    Value = 0;
                    Value2 = 0;
                }, "Beenden mit dem Zurücksetzen der Werte auf 0")
                .BDDfy("Einfache Addition");

            Value2.Should().Be(0);
            Value.Should().Be(0);
        }


        public int Value2 { get; set; }


        public int Value { get; set; }
    }
}
