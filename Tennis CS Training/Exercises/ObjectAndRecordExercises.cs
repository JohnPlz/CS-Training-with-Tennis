namespace Tennis_CS_Training.Exercises;

public class Spielerin
{
    public string Name { get; set; } = string.Empty;

    public int Alter { get; set; }

    public bool HatEigenenSchlaeger { get; set; }
}

public class TrainingsGruppe
{
    public string GruppenName { get; set; } = string.Empty;

    public int Teilnehmerzahl { get; set; }

    public int MaximaleTeilnehmerzahl { get; set; }
}

public record MatchBericht(string NameSpielerin, string NameGegnerin, int GewonneneSpiele, int VerloreneSpiele);

public static class ObjectAndRecordExercises
{
    // Aufgabe 21:
    // Erzeuge ein Objekt vom Typ Spielerin.
    // übernimm alle übergebenen Werte in die passenden Eigenschaften.
    public static Spielerin ErzeugeSpielerin(string name, int alter, bool hatEigenenSchlaeger)
    {
        throw new NotImplementedException();
    }

    // Aufgabe 22:
    // Eine Trainingsgruppe hat noch Platz, wenn die aktülle Teilnehmerzahl
    // kleiner ist als die maximale Teilnehmerzahl.
    // Gib zurück, ob noch mindestens ein Platz frei ist.
    public static bool HatTrainingsgruppeNochPlatz(TrainingsGruppe trainingsGruppe)
    {
        throw new NotImplementedException();
    }

    // Aufgabe 23:
    // Nimm mehrere neü Spielerinnen in eine Trainingsgruppe auf.
    // Erhoehe dazu die Teilnehmerzahl um die übergebene Anzahl und gib das gleiche Objekt zurück.
    public static TrainingsGruppe NimmSpielerinnenInGruppeAuf(TrainingsGruppe trainingsGruppe, int neüSpielerinnen)
    {
        throw new NotImplementedException();
    }

    // Aufgabe 24:
    // Erzeuge einen MatchBericht als Record mit allen übergebenen Daten.
    public static MatchBericht ErzeugeMatchBericht(string nameSpielerin, string nameGegnerin, int gewonneneSpiele, int verloreneSpiele)
    {
        throw new NotImplementedException();
    }

    // Aufgabe 25:
    // Formatiere aus einem MatchBericht einen kurzen Text.
    // Beispiel: "Mila gegen Sara: 6:4 Spiele."
    public static string FormatiereKurzbericht(MatchBericht matchBericht)
    {
        throw new NotImplementedException();
    }
}