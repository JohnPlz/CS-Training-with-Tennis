using Tennis_CS_Training.Exercises;

namespace Tennis_CS_Training.Tests;

public class StringAndReportExercisesTests
{
    [Fact]
    public void FormatiereSpielstandsAnsage_SollLesbarenSatzLiefern()
    {
        string ansage = StringAndReportExercises.FormatiereSpielstandsAnsage("Mila", 30, 15);

        Assert.Equal("Mila steht bei 30:15.", ansage);
    }

    [Fact]
    public void ZaehleVorhandSchlaege_SollExakteTrefferZaehlen()
    {
        int vorhandAnzahl = StringAndReportExercises.ZaehleVorhandSchlaege(["Vorhand", "Volley", "Vorhand", "Rückhand"]);

        Assert.Equal(2, vorhandAnzahl);
    }

    [Fact]
    public void FiltereSchnelleAufschlaege_SollNurSchnelleWerteLiefern()
    {
        int[] schnelleAufschlaege = StringAndReportExercises.FiltereSchnelleAufschlaege([121, 148, 133, 159], 140);

        Assert.Equal([148, 159], schnelleAufschlaege);
    }

    [Fact]
    public void ErzeugeMiniAnzeigetafel_SollNamenUndPunkteVerbinden()
    {
        string[] anzeigetafel = StringAndReportExercises.ErzeugeMiniAnzeigetafel(["Mila", "Sara"], [15, 30]);

        Assert.Equal(["Mila: 15", "Sara: 30"], anzeigetafel);
    }

    [Fact]
    public void BerechneDurchschnittlicheAufschlagGeschwindigkeit_SollMittelwertLiefern()
    {
        double durchschnitt = StringAndReportExercises.BerechneDurchschnittlicheAufschlagGeschwindigkeit([120, 130, 140]);

        Assert.Equal(130, durchschnitt);
    }

    [Theory]
    [InlineData("Mila", "Sara", 2, 1, "Mila")]
    [InlineData("Mila", "Sara", 1, 2, "Sara")]
    [InlineData("Mila", "Sara", 1, 1, "Unentschieden")]
    public void GibMatchSiegerin_SollFuehrendeSpielerinOderUnentschiedenLiefern(string spielerinEins, string spielerinZwei, int saetzeSpielerinEins, int saetzeSpielerinZwei, string erwartet)
    {
        string siegerin = StringAndReportExercises.GibMatchSiegerin(spielerinEins, spielerinZwei, saetzeSpielerinEins, saetzeSpielerinZwei);

        Assert.Equal(erwartet, siegerin);
    }

    [Fact]
    public void ErzeugeTrainingsZusammenfassung_SollDenErwartetenSatzBauen()
    {
        string zusammenfassung = StringAndReportExercises.ErzeugeTrainingsZusammenfassung("Mila", 8, 10, 14);

        Assert.Equal("Mila: 8/10 Aufschläge im Feld, längster Ballwechsel 14.", zusammenfassung);
    }
}