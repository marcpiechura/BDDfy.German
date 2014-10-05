##Beschreibung
Erweitert BDDfy um die deutsche Sprache.


#Beispiel
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
	                .Und(() => Value2.Should().Be(1), "Soll der zweite Wert 1 sein")
	                .BDDfy("Einfache Addition");
	        }
	
	        public int Value2 { get; set; }
	
	
	        public int Value { get; set; }
        }
