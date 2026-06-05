# CS-Training-with-Tennis

Diese kleine Trainingsloesung soll einer Praktikantin die Basics von C# anhand von Tennis-Beispielen beibringen.

Die Aufgaben sind direkt als Kommentare über leeren Methoden formuliert. Die erwartete fachliche Loesung wird über Unit-Tests beschrieben.

Die Methodennamen und Parameter sind bewusst deutsch gehalten, damit die Aufgaben sprachlich moeglichst nah an der Fachlogik bleiben.

Reihenfolge der Themen:

1. Einfache Methoden, Rückgabewerte und Rechenoperatoren
2. Bedingungen mit `if`, `else` und booleschen Ausdrücken
3. Schleifen über Arrays
4. Strings, Arrays und kleine Auswertungen
5. Klassen, Objekte und Records

Schwierigkeitsstufen:

1. Leicht: Aufgaben 1 bis 6
2. Mittel: Aufgaben 7 bis 14
3. Anspruchsvoller: Aufgaben 15 bis 25

Vorschlag für einen 4-Wochen-Plan:

1. Woche 1: Aufgaben 1 bis 5 für Rechenoperatoren, Parameter und erste Entscheidungen
2. Woche 2: Aufgaben 6 bis 10 für Bedingungen, boolesche Logik und Arrays
3. Woche 3: Aufgaben 11 bis 20 für Schleifen, Strings und kleinere Auswertungen
4. Woche 4: Aufgaben 21 bis 25 für Klassen, Objekte, Referenzen und Records

Wichtiger Hinweis:

Die Methoden werfen absichtlich `NotImplementedException`, solange die Aufgabe noch nicht geloest ist. Deshalb sind die Tests anfangs rot. Sobald eine Methode korrekt implementiert ist, sollten die passenden Tests grün werden.

Tests ausführen:

```powershell
dotnet test "Tennis CS Training.slnx"
```

Musterloesungen für die ersten drei Aufgaben liegen in [Musterloesungen/Erste-Aufgaben.md](Musterloesungen/Erste-Aufgaben.md).