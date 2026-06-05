# Musterloesungen für die ersten drei Aufgaben

Diese Datei ist für Nachbesprechungen gedacht. Sinnvoll ist, dass die Praktikantin die Aufgaben zuerst selbst bearbeitet und nur bei Bedarf hier nachschaut.

## Aufgabe 1: Gewonnene Punkte addieren

```csharp
public static int ZaehleGewonnenePunkte(int punkteAusVorhand, int punkteAusRueckhand)
{
    return punkteAusVorhand + punkteAusRueckhand;
}
```

Die Methode braucht nur beide Werte zu addieren und die Summe zurückzugeben.

## Aufgabe 2: Verbleibende Bälle berechnen

```csharp
public static int BerechneVerbleibendeBaelle(int baelleAmStart, int verloreneBaelle)
{
    int verbleibendeBaelle = baelleAmStart - verloreneBaelle;

    if (verbleibendeBaelle < 0)
    {
        return 0;
    }

    return verbleibendeBaelle;
}
```

Hier wird zuerst subtrahiert. Anschliessend verhindert eine einfache Bedingung, dass ein negativer Wert zurückgegeben wird.

## Aufgabe 3: Spiele in Punkte umrechnen

```csharp
public static int WandleSpieleInPunkteUm(int gewonneneSpiele)
{
    return gewonneneSpiele * 4;
}
```

Die Aufgabe trainiert vor allem Parameter, Rückgabewert und Multiplikation.