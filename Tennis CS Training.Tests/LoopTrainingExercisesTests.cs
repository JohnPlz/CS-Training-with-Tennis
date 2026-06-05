using Tennis_CS_Training.Exercises;

namespace Tennis_CS_Training.Tests;

public class LoopTrainingExercisesTests
{
    [Fact]
    public void AddiereAufschlagPunkte_SollAlleWerteAddieren()
    {
        int gesamtPunkte = LoopTrainingExercises.AddiereAufschlagPunkte([4, 6, 5, 3]);

        Assert.Equal(18, gesamtPunkte);
    }

    [Theory]
    [InlineData(new[] { 4, 12, 8, 9 }, 12)]
    [InlineData(new int[0], 0)]
    public void FindeLaengstenBallwechsel_SollGroesstenWertOderNullLiefern(int[] ballwechselLaengen, int erwartet)
    {
        int laengsterBallwechsel = LoopTrainingExercises.FindeLaengstenBallwechsel(ballwechselLaengen);

        Assert.Equal(erwartet, laengsterBallwechsel);
    }

    [Fact]
    public void ZaehleErsteAufschlaegeImFeld_SollTrueWerteZaehlen()
    {
        int erfolgreicheAufschlaege = LoopTrainingExercises.ZaehleErsteAufschlaegeImFeld([true, false, true, true, false]);

        Assert.Equal(3, erfolgreicheAufschlaege);
    }

    [Theory]
    [InlineData(3, "3, 2, 1, Serve!")]
    [InlineData(1, "1, Serve!")]
    public void ErzeugeCountdownZumAufschlag_SollDenTextAufbauen(int startzahl, string erwartet)
    {
        string countdown = LoopTrainingExercises.ErzeugeCountdownZumAufschlag(startzahl);

        Assert.Equal(erwartet, countdown);
    }
}