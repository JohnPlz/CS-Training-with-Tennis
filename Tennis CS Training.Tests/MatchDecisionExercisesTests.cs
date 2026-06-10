using Tennis_CS_Training.Exercises;

namespace Tennis_CS_Training.Tests;

public class MatchDecisionExercisesTests
{
    [Theory]
    [InlineData(6, 6, true)]
    [InlineData(6, 5, false)]
    [InlineData(7, 6, false)]
    public void IstTieBreakNoetig_SollNurBeiSechsZuSechsWahrSein(int spieleSpielerin, int spieleGegnerin, bool erwartet)
    {
        bool istTieBreakNoetig = MatchDecisionExercises.IstTieBreakNoetig(spieleSpielerin, spieleGegnerin);

        Assert.Equal(erwartet, istTieBreakNoetig);
    }

    [Theory]
    [InlineData(6, 4, true)]
    [InlineData(7, 5, true)]
    [InlineData(6, 5, false)]
    [InlineData(5, 3, false)]
    public void HatSpielerinSatzGewonnen_SollSechsSpieleUndZweiVorsprungVerlangen(int spieleSpielerin, int spieleGegnerin, bool erwartet)
    {
        bool hatSatzGewonnen = MatchDecisionExercises.HatSpielerinSatzGewonnen(spieleSpielerin, spieleGegnerin);

        Assert.Equal(erwartet, hatSatzGewonnen);
    }

    [Theory]
    [InlineData(1, "Erster Aufschlag")]
    [InlineData(2, "Zweiter Aufschlag")]
    [InlineData(0, "Ungültig")]
    public void GibAufschlagBezeichnung_SollAufschlagNummerInTextUebersetzen(int aufschlagNummer, string erwartet)
    {
        string aufschlagBezeichnung = MatchDecisionExercises.GibAufschlagBezeichnung(aufschlagNummer);

        Assert.Equal(erwartet, aufschlagBezeichnung);
    }

    [Theory]
    [InlineData(true, true, true, true)]
    [InlineData(true, false, true, false)]
    [InlineData(false, true, true, false)]
    public void KannTrainingStarten_SollAlleBedingungenVerlangen(bool hatSchlaeger, bool hatBaelle, bool platzReserviert, bool erwartet)
    {
        bool kannTrainingStarten = MatchDecisionExercises.KannTrainingStarten(hatSchlaeger, hatBaelle, platzReserviert);

        Assert.Equal(erwartet, kannTrainingStarten);
    }

    [Theory]
    [InlineData(4, 2, "Führt")]
    [InlineData(3, 3, "Gleichstand")]
    [InlineData(2, 5, "Liegt zurück")]
    public void VergleicheSatzstand_SollDenAktuellenStandBeschreiben(int spieleSpielerin, int spieleGegnerin, string erwartet)
    {
        string satzstandBeschreibung = MatchDecisionExercises.VergleicheSatzstand(spieleSpielerin, spieleGegnerin);

        Assert.Equal(erwartet, satzstandBeschreibung);
    }
}