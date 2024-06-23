# LB306MeierMeisterJeanneretGilardoni

## 1. Informieren

### 1.1 Anforderungsanalyse

| An-№ | Typ           | Beschreibung                                                                      |
| ---- | ------------- | ---------------------------------------------------------------------------------- |
| 1    | Funktional    | Das Spiel soll eine einfache und präzise Steuerung von Pac-Man haben.              |
| 2    | Funktional    | Das Spiel gibt eine Belohnung für das Sammeln von Punkten.                         |
| 3    | Funktional    | Die Geister sollen unterschiedliche Bewegungsmuster haben.                        |
| 4    | Funktional    | Das Spiel soll verschiedene Kartenlayouts und Schwierigkeitsgrade haben.           |
| 5    | Funktional    | Das Spiel soll ansprechende Musik und Soundeffekte haben.                          |
| 6    | Qualität      | Das Spiel soll eine intuitive und leicht navigierbare UI haben.                    |
| 7    | Funktional    | Das Spiel soll Power-ups haben, um temporäre Vorteile im Spiel zu erhalten.        |
| 8    | Funktional    | Das Spiel soll eine Speicherung und Anzeige der besten Spielergebnisse haben.      |

### 1.2 User-Storys

| US-№ | An-№ | Verbindlichkeit | Beschreibung                                                                 |
| ---- | ---- | ---------------- | ---------------------------------------------------------------------------- |
| 1.1  | 1    | muss             | Als User möchte ich die Richtung ändern können, um mich auf der Map zu bewegen. |
| 1.2  | 1    | muss             | Als User möchte ich, dass die Spielfigur die Bahn nicht verlassen kann.       |
| 2.1  | 2    | muss             | Als User möchte ich für die erreichte Punktzahl eine Belohnung erhalten.     |
| 3.1  | 3    | muss             | Als User möchte ich, dass zwei Geister direkt von vorne angreifen.           |
| 3.2  | 3    | muss             | Als User möchte ich, dass ein Geist von hinten angreift.                     |
| 3.3  | 3    | muss             | Als User möchte ich, dass ein Geist aus verschiedenen Richtungen kommt.      |
| 3.4  | 3    | muss             | Als User möchte ich, dass der Spieler bei einer Kollision mit einem Geist stirbt. |
| 3.5  | 3    | muss             | Als User möchte ich, dass gefressene Geister nach einer gewissen Zeit respawnen. |
| 4.1  | 4    | muss             | Als User möchte ich drei verschiedene Maps zur Auswahl haben.                |
| 4.2  | 4    | muss             | Als User möchte ich drei verschiedene Schwierigkeitsgrade zur Auswahl haben. |
| 5.1  | 5    | muss             | Als User möchte ich Hintergrundmusik im Spiel haben.                         |
| 5.2  | 5    | muss             | Als User möchte ich einen Sound-Effekt für den Tod der Spielfigur haben.     |
| 5.3  | 5    | muss             | Als User möchte ich einen Sound-Effekt für das Power-up haben.               |
| 5.4  | 5    | muss             | Als User möchte ich einen Sound-Effekt für die Aktivierung des Power-ups haben. |
| 5.5  | 5    | muss             | Als User möchte ich einen Sound-Effekt für den Tod eines Geistes haben.      |
| 7.1  | 7    | muss             | Als User möchte ich in ein Item laufen können, um das Power-up zu aktivieren. |
| 7.2  | 7    | muss             | Als User möchte ich während der Power-up-Zeit Geister fressen können.        |
| 8.1  | 8    | muss             | Als User möchte ich, dass der Highscore durchgehend angezeigt wird.          |
| 8.2  | 8    | muss             | Als User möchte ich, dass der Score der letzten Runde im Main-Screen angezeigt wird. |
| 8.3  | 8    | muss             | Als User möchte ich, dass meine Anzahl Coins durchgehend angezeigt wird.     |

## 2. Planen

### 2.1 Arbeitspakete

| AP-№  | Zuständig      | Frist       | Beschreibung                                                                | Geplante Zeit |
| ----- | -------------- | ----------- | --------------------------------------------------------------------------- | ------------- |
| 1     | Jeanneret/Meister| 14.5.24     | Erstellung des Projektplans und Festlegung der Meilensteine               | 90 min        |
| 1.1   | Jeanneret/Meister| 14.5.24     | Detaillierte Anforderungsanalyse und Erstellung der User Stories          | 120 min       |
| 1.2   | Jeanneret/Meister| 21.5.24     | Erstellung der Arbeitspakete                                              | 45 min        |
| 1.3   | Jeanneret/Meister| 21.5.24     | Erstellung des Zeitplans                                                  | 105 min       |
| 1.4   | Jeanneret/Meister| 21.5.24     | Erstellung der Testfälle                                                  | 75 min        |
| 2     | Jeanneret/Meister  | 21.5.24     | Entscheiden                                                       | 60 min        |
| 3     | Meyer/Gilardoni  | 28.5.24     | Implementierung der Steuerung und Bewegungsmuster der Geister             | 90 min        |
| 3.1   | Meyer/Gilardoni  | 28.5.24     | Entwicklung der Steuerung von Pac-Man                                     | 75 min        |
| 3.2   | Meyer/Gilardoni  | 28.5.24       | Programmierung der Bewegungsmuster der Geister                            | 90 min        |
| 4     | Meyer/Gilardoni  | 28.5.24      | Entwicklung des Punkte- und Belohnungssystems                             | 105 min       |
| 4.1   | Meyer/Gilardoni  | 4.6.24      | Design der Punktevergabe                                                  | 60 min        |
| 4.2   | Meyer/Gilardoni  | 4.6.24      | Integration der Belohnungen und Feedbackmechanismen                       | 90 min        |
| 5     | Meyer/Gilardoni  | 4.6.24    | Einbindung von Musik und Soundeffekten                                    | 105 min       |
| 5.1   | Meyer/Gilardoni  | 4.6.24     | Auswahl der Musik und Soundeffekte                                        | 45 min        |
| 5.2   | Meyer/Gilardoni  | 4.6.24     | Implementierung der Soundeffekte im Spiel                                 | 75 min        |
| 6     | Meyer/Gilardoni  | 11.6.24     | Gestaltung der Benutzeroberfläche                                         | 120 min       |
| 6.1   | Meyer/Gilardoni  | 11.6.24     | Entwicklung und Implementierung der finalen Benutzeroberfläche            | 105 min       |
| 7     | Jeanneret/Meister       | 11.6.24 | Durchführung von Tests und Debugging                                        | 90 min        |
| 7.1   | alle      | 11.6.24  | Durchführung der Tests und Fehlerbehebung                                   | 75 min        |
| 8     | Jeanneret/Meister       | 18.6.24 | Dokumentation der Testergebnisse und Qualitätskontrolle                     | 105 min       |
| 8.1   | Jeanneret/Meister       | 18.6.24  | Erstellung eines Testberichts                                               | 60 min        |
| 8.2   | Meyer/Gilardoni       | 18.6.24  | Durchführung einer abschließenden Qualitätsprüfung                          | 90 min        |
| 9     | Jeanneret/Meister      | 18.6.24   | Reflexion und Auswertung des Projekts                                       | 75 min        |
| 9.1   | Gilardoni      |  18.6.24  | Präsentation vorbereiten                                                    | 30 min        |
| 9.2   | alle      |  25.6.24  | Präsentation vortragen                                                      | 60 min        |

## 2.2 Zeitplan 

## Woche 1

### Dienstag, 14. Mai 2024

| Zeitblock | Geplante Aktivität | Tatsächliche Aktivität | Vergleich |
|:---------:|:------------------:|:----------------------:|:------------------:|
| 07:30-08:30 | Anforderungsanalyse | Anforderungsanalyse | ✔️ |
| 08:35-09:35 | User-Stories | User-Stories | ✔️ |
| 09:40-10:40 | User-Stories | User-Stories | ✔️ |
| 10:45-11:45 | Arbeitsjournal | Arbeitsjournal | ✔️ |

## Woche 2

### Dienstag, 21. Mai 2024

| Zeitblock | Geplante Aktivität | Tatsächliche Aktivität | Vergleich |
|:---------:|:------------------:|:----------------------:|:------------------:|
| 07:30-08:30 | Arbeitspakete | Arbeitspakete | ✔️ |
| 08:35-09:35 | Arbeitspakete | Arbeitspakete | ✔️ |
| 09:40-10:40 | Arbeitspacket | Arbeitspacket | ✔️ |
| 10:45-11:45 | Entscheiden | Entscheiden | ✔️ |

## Woche 3

### Dienstag, 28. Mai 2024

| Zeitblock | Geplante Aktivität | Tatsächliche Aktivität | Vergleich |
|:---------:|:------------------:|:----------------------:|:------------------:|
| 07:30-08:30 | Code | Code | ✔️ |
| 08:35-09:35 | Code | Code | ✔️ |
| 09:40-10:40 | Code | Code | ✔️ |
| 10:45-11:45 | Arbeitsjournal | Arbeitsjournal | ✔️ |

## Woche 4

### Dienstag, 04. Juni 2024

| Zeitblock | Geplante Aktivität | Tatsächliche Aktivität | Vergleich |
|:---------:|:------------------:|:----------------------:|:------------------:|
| 07:30-08:30 | Code | Code | ✔️ |
| 08:35-09:35 | Code | Code | ✔️ |
| 09:40-10:40 | Code | Code | ✔️ |
| 10:45-11:45 | Arbeitsjournal | Arbeitsjournal | ✔️ |

## Woche 5

### Dienstag, 11. Juni 2024

| Zeitblock | Geplante Aktivität | Tatsächliche Aktivität | Vergleich |
|:---------:|:------------------:|:----------------------:|:------------------:|
| 07:30-08:30 | Code | Code | ✔️ |
| 08:35-09:35 | Code | Code | ✔️ |
| 09:40-10:40 | Code | Code | ✔️ |
| 10:45-11:45 | Arbeitsjournal | Arbeitsjournal | ✔️ |

## Woche 6

### Dienstag, 18. Juni 2024

| Zeitblock | Geplante Aktivität | Tatsächliche Aktivität | Vergleich |
|:---------:|:------------------:|:----------------------:|:------------------:|
| 07:30-08:30 | Testbericht | Testbericht | ✔️ |
| 08:35-09:35 | Auswerten | Auswerten | ✔️ |
| 09:40-10:40 | Präsenationvorbereitung | Präsenationvorbereitung | ✔️ |
| 10:45-11:45 | Arbeitsjournal | Arbeitsjournal | ✔️ |

## Woche 7

### Dienstag, 24. Juni 2024

| Zeitblock | Geplante Aktivität | Tatsächliche Aktivität | Vergleich |
|:---------:|:------------------:|:----------------------:|:------------------:|
| 07:30-08:30 | Präsentation | Präsentation | ✔️ |
| 08:35-09:35 | Präsentation | Präsentation | ✔️ |
| 09:40-10:40 | Präsentation | Präsentation | ✔️ |
| 10:45-11:45 | Präsentation | Präsentation | ✔️ |

### 2.3 Testfälle

| TC-№ | Ausgangslage                      | Eingabe                                               | Erwartete Ausgabe                                               |
| ---- | --------------------------------- | ----------------------------------------------------- | ---------------------------------------------------------------- |
| 1.1  | PC ist gestartet                  | Applikation öffnen                                    | Applikation öffnet sich.                                         |
| 1.2  | Applikation ist geöffnet, Pac-Man ist auf der Map | Pfeiltasten nach oben, unten, rechts, links drücken  | Pac-Man ändert die Richtung entsprechend der Eingabe.           |
| 1.3  | Applikation ist geöffnet, Pac-Man ist am Rand der Bahn | Pfeiltaste drücken, um die Bahn zu verlassen       | Pac-Man bleibt innerhalb der Bahn.                              |
| 2.1  | Pac-Man sammelt Punkte            | Punkte sammeln                                        | In-Game-Coins werden entsprechend der gesammelten Punkte gutgeschrieben. |
| 3.1  | Spiel ist gestartet, Geister sind auf der Map | Spiel läuft                                       | Zwei Geister greifen direkt von vorne an.                       |
| 3.2  | Spiel ist gestartet, Geister sind auf der Map | Spiel läuft                                       | Ein Geist greift von hinten an.                                 |
| 3.3  | Spiel ist gestartet, Geister sind auf der Map | Spiel läuft                                       | Ein Geist greift aus verschiedenen Richtungen an.               |
| 3.4  | Pac-Man trifft auf einen Geist    | Spiel läuft                                           | Pac-Man stirbt bei der Kollision mit einem Geist.                |
| 3.5  | Pac-Man hat einen Geist gefressen | Spiel läuft                                           | Gefressener Geist respawnt nach einer bestimmten Zeit.           |
| 4.1  | Applikation ist geöffnet          | Drei verschiedene Maps zur Auswahl haben              | Benutzer kann zwischen drei verschiedenen Maps wählen.           |
| 4.2  | Applikation ist geöffnet          | Drei verschiedene Schwierigkeitsgrade zur Auswahl haben | Benutzer kann zwischen drei verschiedenen Schwierigkeitsgraden wählen. |
| 5.1  | Applikation ist geöffnet          | Spiel starten                                         | Hintergrundmusik spielt während des Spiels.                      |
| 5.2  | Pac-Man stirbt im Spiel           | Spiel läuft                                           | Sound-Effekt für den Tod der Spielfigur wird abgespielt.         |
| 5.3  | Pac-Man aktiviert ein Power-up    | Spiel läuft                                           | Sound-Effekt für die Aktivierung des Power-ups wird abgespielt.  |
| 5.4  | Pac-Man hat ein Power-up          | Spiel läuft                                           | Sound-Effekt für die Power-up-Zeit wird abgespielt.              |
| 5.5  | Pac-Man frisst einen Geist während des Power-ups | Spiel läuft                                  | Sound-Effekt für den Tod des Geistes wird abgespielt.            |
| 7.1  | Spiel ist gestartet, ein Power-up erscheint auf der Map | Pac-Man läuft in das Power-up             | Power-up wird aktiviert.                                         |
| 7.2  | Pac-Man hat ein Power-up          | Spiel läuft                                           | Pac-Man kann während der Power-up-Zeit Geister fressen.          |
| 8.1  | Applikation ist geöffnet          | Spiel läuft                                           | Highscore wird durchgehend angezeigt.                            |
| 8.2  | Spiel ist zu Ende                 | Spiel ist beendet                                     | Score der letzten Runde wird im Main-Screen angezeigt.           |
| 8.3  | Applikation ist geöffnet          | Spiel läuft                                           | Anzahl Coins wird durchgehend angezeigt.                         |


## 3. Entscheiden

### 3.1 Präferenzmatrix

Ziel 1: Spielbarkeit
Ziel 2: Highscore
Ziel 3: Musik und Soundeffect
Ziel 4: Replayability
Ziel 5: Kompabilität

|        | Ziel 1 | Ziel 2 | Ziel 3 | Ziel 4 | Ziel 5 |
| ------ | ------ | ------ | ------ | ------ | ------ |
| Ziel 1 |   -    |   1    |   1    |   1    |   1    |
| Ziel 2 |   -    |   -    |   2    |   2    |   2    |
| Ziel 3 |   -    |   -    |   -    |   4    |   3    |
| Ziel 4 |   -    |   -    |   -    |   -    |   4    |
| Ziel 5 |   -    |   -    |   -    |   -    |   -    |
 
             4        3        1        2        0        =  10

Kontrolle    (5 * (5-1)) : 2 = 10

|        | Ziel 1 |  Ziel 2 |  Ziel 3 |  Ziel 4 |  Ziel 5 |
| ------ | ------ | ------ | ------ | ------ | ------ |
| Faktor |   4    |    3    |    1    |    2    |    0    |
| Prozent|   40   |    30   |    10   |    20   |    -    |
| Rang   |   1    |    2    |    4    |    3    |    -    |

### 3.2 Nutzwertanalyse

|        |        | Langsam | Mittel | Schnell |
|--------|--------|--------|--------|--------|
|Kriterien|Gewichtung|TN/GTN|TN/GTN |TN/GTN|
|Spielbarkeit| 40%|   6/240 |    10/400|   6|240   |
|Highscore| 30%   |    5/150     |    5/150 |     5/150 |
|Musik und Soundeffect|10%|   2/20  |  8/80  |     10/100    |
|Replayability| 20%|    1/20    |     6/120   |     8/160    |
|Gesamtnutzen| 100%|    430    |   750   |   650     | 

## 4. Realisieren

### 4.1 
| AP-№ | Datum             | Zuständig   | geplante Zeit | tatsächliche Zeit |
| ---- | ----------------- | ----------- | ------------- | ----------------- |
| 1.A  | 20.6.24           | Jeanneret   | 20 min        | 40 min            |

### 4.2 Technologien und Werkzeuge
Für die Entwicklung des Pac-Man-Spiels wurden die folgenden Technologien und Werkzeuge verwendet:

- **Programmiersprache:** Python
- **Frameworks:** Pygame
- **IDE:** Visual Studio Code
- **Versionsverwaltung:** GitHub

### 4.3 Implementierungsschritte
Die Implementierung des Pac-Man-Spiels erfolgte in den folgenden Schritten:

1. **Erstellung des Spiellayouts:** Gestaltung der verschiedenen Kartenlayouts und Platzierung der Elemente (Pac-Man, Geister, Punkte, Power-ups).
2. **Implementierung der Steuerung:** Programmierung der Steuerung von Pac-Man und der Bewegungsmuster der Geister.
3. **Punkte- und Belohnungssystem:** Entwicklung des Systems zur Punktevergabe und Aktivierung der Power-ups.
4. **Musik und Soundeffekte:** Einbindung von Hintergrundmusik und Soundeffekten für verschiedene Spielereignisse.
5. **Benutzeroberfläche:** Gestaltung der Benutzeroberfläche mit Anzeige von Punkten, Highscores und weiteren Informationen.
6. **Tests und Debugging:** Durchführung von Tests zur Sicherstellung der Funktionalität und Behebung von Fehlern.

### 4.4 Herausforderungen und Lösungen
Während der Umsetzung des Projekts traten verschiedene Herausforderungen auf, die wie folgt gelöst wurden:

- **Herausforderung:** Synchronisation der Geisterbewegungen mit der Spielgeschwindigkeit.
  - **Lösung:** Anpassung der Bewegungsmuster und Geschwindigkeiten der Geister, um eine konsistente Spielgeschwindigkeit zu gewährleisten.

- **Herausforderung:** Implementierung der Kollisionsabfrage zwischen Pac-Man und den Geistern.
  - **Lösung:** Verwendung von Pygame-Funktionen zur präzisen Kollisionsabfrage und Reaktion auf Kollisionen.

## 5. Kontrollieren

### 5.1 Testprotokolle
Die Testergebnisse wurden in Testprotokollen dokumentiert, um die erfolgreiche Durchführung und das Bestehen der Tests nachzuweisen.

| TC-№ | Ergebnis        | Bemerkungen                                           |
| ---- | --------------- | ----------------------------------------------------- |
| 1.1  | Bestanden       | Applikation öffnet sich problemlos.                   |
| 1.2  | Bestanden       | Pac-Man ändert die Richtung entsprechend der Eingabe. |
| 1.3  | Bestanden       | Pac-Man bleibt innerhalb der Bahn.                    |
| 2.1  | Bestanden       | In-Game-Coins werden gutgeschrieben.                  |
| 3.1  | Bestanden       | Zwei Geister greifen direkt von vorne an.             |
| 3.2  | Bestanden       | Ein Geist greift von hinten an.                       |
| 3.3  | Bestanden       | Ein Geist greift aus verschiedenen Richtungen an.     |
| 3.4  | Bestanden       | Pac-Man stirbt bei Kollision mit einem Geist.         |
| 3.5  | Bestanden       | Gefressener Geist respawnt nach einer bestimmten Zeit.|
| 4.1  | Bestanden       | Benutzer kann zwischen drei verschiedenen Maps wählen.|
| 4.2  | Bestanden       | Benutzer kann zwischen drei verschiedenen Schwierigkeitsgraden wählen. |
| 5.1  | Bestanden       | Hintergrundmusik spielt während des Spiels.           |
| 5.2  | Bestanden       | Sound-Effekt für den Tod der Spielfigur wird abgespielt.|
| 5.3  | Bestanden       | Sound-Effekt für die Aktivierung des Power-ups wird abgespielt. |
| 5.4  | Bestanden       | Sound-Effekt für die Power-up-Zeit wird abgespielt.   |
| 5.5  | Bestanden       | Sound-Effekt für den Tod des Geistes wird abgespielt. |
| 7.1  | Bestanden       | Power-up wird aktiviert.                              |
| 7.2  | Bestanden       | Pac-Man kann während der Power-up-Zeit Geister fressen.|
| 8.1  | Bestanden       | Highscore wird durchgehend angezeigt.                 |
| 8.2  | Bestanden       | Score der letzten Runde wird im Main-Screen angezeigt.|
| 8.3  | Bestanden       | Anzahl Coins wird durchgehend angezeigt.              |

## 6. Auswerten

### 6.1 Reflexion und Lessons Learned
Während des Projekts wurden wertvolle Erfahrungen gesammelt und wichtige Erkenntnisse gewonnen:

- **Projektmanagement:** Die IPERKA-Methode hat sich als sehr effektiv erwiesen, um das Projekt strukturiert und zielgerichtet durchzuführen.
- **Teamarbeit:** Die Zusammenarbeit im Team war entscheidend für den Erfolg des Projekts. Klare Kommunikation und regelmäßige Meetings haben dazu beigetragen, Probleme frühzeitig zu erkennen und zu lösen.
- **Technische Fähigkeiten:** Die Arbeit an diesem Projekt hat die technischen Fähigkeiten in Python und Pygame erheblich verbessert.
- **Qualitätssicherung:** Die Bedeutung von umfangreichen Tests und kontinuierlichem Debugging wurde deutlich, um ein qualitativ hochwertiges Endprodukt zu gewährleisten.

### 6.2 Fazit
Das Pac-Man-Projekt war ein großer Erfolg und hat alle gesetzten Ziele erreicht. Durch die Anwendung der IPERKA-Methode konnten alle Phasen des Projekts strukturiert und effizient durchgeführt werden. Die entwickelten Funktionen und Features des Spiels entsprechen den Anforderungen und bieten ein unterhaltsames und herausforderndes Spielerlebnis. Die gesammelten Erfahrungen und Erkenntnisse werden in zukünftigen Projekten von großem Nutzen sein.
