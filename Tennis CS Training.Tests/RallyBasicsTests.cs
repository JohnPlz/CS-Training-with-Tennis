using Tennis_CS_Training.Exercises;

namespace Tennis_CS_Training.Tests;

public class RallyBasicsTests
{
    [Fact]
    public void ZaehleGewonnenePunkte_SollAllePunkteAddieren()
    {
        int gesamtPunkte = RallyBasicsExercises.ZaehleGewonnenePunkte(3, 2);

        Assert.Equal(5, gesamtPunkte);
    }

    [Theory]
    [InlineData(10, 3, 7)]
    [InlineData(4, 10, 0)]
    public void BerechneVerbleibendeBaelle_SollNieNegativeAnzahlLiefern(int baelleAmStart, int verloreneBaelle, int erwartet)
    {
        int verbleibendeBaelle = RallyBasicsExercises.BerechneVerbleibendeBaelle(baelleAmStart, verloreneBaelle);

        Assert.Equal(erwartet, verbleibendeBaelle);
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(3, 12)]
    [InlineData(6, 24)]
    public void WandleSpieleInPunkteUm_SollMitVierMultiplizieren(int gewonneneSpiele, int erwartetePunkte)
    {
        int gesamtPunkte = RallyBasicsExercises.WandleSpieleInPunkteUm(gewonneneSpiele);

        Assert.Equal(erwartetePunkte, gesamtPunkte);
    }

    [Theory]
    [InlineData(12, 3, 15)]
    [InlineData(20, 0, 20)]
    public void BerechnePunkteMitBonus_SollRegulaereUndBonusPunkteAddieren(int regulaerePunkte, int bonusPunkte, int erwartet)
    {
        int gesamtPunkte = RallyBasicsExercises.BerechnePunkteMitBonus(regulaerePunkte, bonusPunkte);

        Assert.Equal(erwartet, gesamtPunkte);
    }
}