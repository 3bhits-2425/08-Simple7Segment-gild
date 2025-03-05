# 7-Segment Anzeige Steuerung in Unity

## Beschreibung
Dieses Unity-Projekt implementiert eine Simulation einer 7-Segment-Anzeige. Die Anzeige besteht aus mehreren Segmenten, die über numerische Tasten gesteuert werden können. Jedes Segment wird einzeln angesprochen, um verschiedene Zahlen von 0 bis 9 darzustellen.

## Funktionen
- **Numerische Steuerung (0-9):**
  - Beim Drücken einer Zahlentaste werden die entsprechenden Segmente weiß eingefärbt.
  - Die Farbe bleibt erhalten, bis eine andere Zahl gedrückt wird.
- **Rotation des Segments:**
  - Beim ersten Tastendruck wird das gesamte Segment um 180° gedreht.
  - Nach der ersten Rotation bleibt die Anzeige in der neuen Orientierung.
- **Automatische Rücksetzung der Farben:**
  - Vor der Aktivierung einer neuen Zahl werden alle Segmente auf Schwarz zurückgesetzt.

## Steuerung
| Taste  | Darstellung |
|--------|------------|
| 0      | Alle Segmente leuchten |
| 1      | Nur rechte Segmente |
| 2      | Bestimmte Segmente für die "2" |
| 3      | Bestimmte Segmente für die "3" |
| 4      | Bestimmte Segmente für die "4" |
| 5      | Bestimmte Segmente für die "5" |
| 6      | Bestimmte Segmente für die "6" |
| 7      | Bestimmte Segmente für die "7" |
| 8      | Alle Segmente leuchten |
| 9      | Bestimmte Segmente für die "9" |

## Implementierungsdetails
- **Segment-Findung:**
  - Jedes Segment wird anhand seines Tags im `Start()`-Methodenaufruf gesucht.
- **Segment-Farbensteuerung:**
  - Die `SetNumberColor(int number)`-Methode aktiviert nur die für die gewählte Zahl notwendigen Segmente.
- **Rotation:**
  - Die `Update()`-Methode überprüft, ob bereits eine Rotation stattgefunden hat.
  - Falls nicht, rotiert das Segment um 180° beim ersten Tastendruck.

## Verwendung
1. Füge das Skript einem GameObject in Unity hinzu.
2. Stelle sicher, dass alle Segmente mit den richtigen Tags versehen sind (`Num1` bis `Num7` und `Par1` für das gesamte Segment).
3. Starte die Szene und benutze die Tasten 0-9, um verschiedene Zahlen darzustellen und das Segment zu drehen.

## Anforderungen
- Unity 2021 oder höher
- Ein 7-Segment-Modell mit korrekt benannten und getaggten Einzelteilen

## Erweiterungsmöglichkeiten
- Hinzufügen einer Funktion zur Rücksetzung der Rotation.
- Implementierung einer Animation für sanftere Übergänge.
- Unterstützung für weitere Farben oder Effekte zur besseren Visualisierung.

---
Dieses Projekt dient als Basis zur Simulation einer 7-Segment-Anzeige und kann flexibel erweitert werden.

