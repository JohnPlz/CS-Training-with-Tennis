using Tennis_CS_Training.Exercises;

namespace Tennis_CS_Training.Tests;

public class ObjectAndRecordExercisesTests
{
    [Fact]
    public void ErzeugeSpielerin_SollEinObjektMitAllenWertenLiefern()
    {
        Spielerin spielerin = ObjectAndRecordExercises.ErzeugeSpielerin("Mila", 16, true);

        Assert.Equal("Mila", spielerin.Name);
        Assert.Equal(16, spielerin.Alter);
        Assert.True(spielerin.HatEigenenSchlaeger);
    }

    [Theory]
    [InlineData(6, 8, true)]
    [InlineData(8, 8, false)]
    public void HatTrainingsgruppeNochPlatz_SollFreiePlaetzePruefen(int teilnehmerzahl, int maximaleTeilnehmerzahl, bool erwartet)
    {
        TrainingsGruppe trainingsGruppe = new()
        {
            GruppenName = "Dienstag 17 Uhr",
            Teilnehmerzahl = teilnehmerzahl,
            MaximaleTeilnehmerzahl = maximaleTeilnehmerzahl,
        };

        bool hatNochPlatz = ObjectAndRecordExercises.HatTrainingsgruppeNochPlatz(trainingsGruppe);

        Assert.Equal(erwartet, hatNochPlatz);
    }

    [Fact]
    public void NimmSpielerinnenInGruppeAuf_SollTeilnehmerzahlErhoehen()
    {
        TrainingsGruppe trainingsGruppe = new()
        {
            GruppenName = "Mittwoch 18 Uhr",
            Teilnehmerzahl = 4,
            MaximaleTeilnehmerzahl = 8,
        };

        TrainingsGruppe aktualisierteGruppe = ObjectAndRecordExercises.NimmSpielerinnenInGruppeAuf(trainingsGruppe, 2);

        Assert.Same(trainingsGruppe, aktualisierteGruppe);
        Assert.Equal(6, aktualisierteGruppe.Teilnehmerzahl);
    }

    [Fact]
    public void ErzeugeMatchBericht_SollEinenRecordMitAllenWertenLiefern()
    {
        MatchBericht matchBericht = ObjectAndRecordExercises.ErzeugeMatchBericht("Mila", "Sara", 6, 4);

        Assert.Equal("Mila", matchBericht.NameSpielerin);
        Assert.Equal("Sara", matchBericht.NameGegnerin);
        Assert.Equal(6, matchBericht.GewonneneSpiele);
        Assert.Equal(4, matchBericht.VerloreneSpiele);
    }

    [Fact]
    public void FormatiereKurzbericht_SollEinenLesbarenTextErzeugen()
    {
        MatchBericht matchBericht = new("Mila", "Sara", 6, 4);

        string kurzbericht = ObjectAndRecordExercises.FormatiereKurzbericht(matchBericht);

        Assert.Equal("Mila gegen Sara: 6:4 Spiele.", kurzbericht);
    }
}