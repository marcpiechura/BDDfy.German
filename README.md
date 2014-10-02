##Beschreibung
Erweitert BDDfy um die deutsche Sprache.


#Beispiel
	[Test]
	public void KarteWurdeDeaktiviert()
	{
		this.Angenommen(s => s.AngenommenDieKarteWurdeDeaktiviert())
			.Wenn(s => s.WennDerBesitzerGeldAbbuchenWill(20))
			.Dann(s => s.KarteIstEingezogen(true), "Dann soll die ATM die Karte einziehen.")
				.Und(s => s.UndDieAtmSollteSagenDasDieKarteEingezogenWurde())
			.BDDfy(htmlReportName: "ATM");
	}
