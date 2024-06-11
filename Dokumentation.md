# LB306MeierMeisterJeanneretGilardoni

# IPA Bericht

## 1. Einleitung
Dieser Bericht dokumentiert die Entwicklung eines Pac-Man-Spiels im Rahmen der individuellen Projektarbeit (IPA). Das Projekt zielt darauf ab, ein unterhaltsames und herausforderndes Pac-Man-Spiel zu erstellen, das verschiedene Kartenlayouts und Schwierigkeitsgrade sowie eine intuitive Benutzeroberfläche und ansprechende Musik und Soundeffekte bietet. Der Entwicklungsprozess wird durch die Anwendung der IPERKA-Methode unterstützt.

## 2. Projektmanagement und Planung

### 2.1 Gewählte Projektmanagement-Methode
Für die Durchführung dieses Projekts wurde die IPERKA-Methode gewählt. Diese Methode eignet sich besonders gut für strukturierte und klar definierte Projekte, da sie einen klaren Ablauf in sechs Phasen bietet: Informieren, Planen, Entscheiden, Realisieren, Kontrollieren und Auswerten.

### 2.2 Anwendung der Projektmanagement-Methode
Die IPERKA-Methode wurde in der praktischen Arbeit durch folgende Maßnahmen angewandt:

- **Informieren:** Sammlung und Analyse von Informationen zu den Anforderungen und Zielen des Projekts.
- **Planen:** Erstellung eines detaillierten Projektplans mit Meilensteinen und Aufgaben.
- **Entscheiden:** Auswahl der besten Vorgehensweise und Technologien für die Umsetzung.
- **Realisieren:** Entwicklung und Implementierung des Pac-Man-Spiels gemäß den Anforderungen.
- **Kontrollieren:** Überprüfung der Fortschritte und Qualitätssicherung durch Tests.
- **Auswerten:** Reflexion über das Projekt, Dokumentation der Ergebnisse und Lessons Learned.

### 2.3 Dokumentation der korrekten Anwendung im IPA-Bericht
Die korrekte Anwendung der IPERKA-Methode ist in diesem Bericht dokumentiert durch:
- Detaillierte Beschreibung der durchgeführten Aktivitäten in jeder Phase.
- Protokolle und Dokumentationen der Planungs- und Entscheidungsprozesse.
- Testergebnisse und Qualitätskontrollen.
- Reflexion und Auswertung des gesamten Projektverlaufs.

### 2.4 Weitergehende Analyse und Verfeinerung des Auftrags
Der Auftrag wurde ausgehend von der ursprünglichen Aufgabenstellung weiter analysiert und verfeinert durch:
- Identifizierung und Beschreibung der Kernfunktionen des Spiels.
- Entwicklung detaillierter User Stories und Akzeptanzkriterien.
- Kontinuierliche Rücksprache mit dem Auftraggeber, um sicherzustellen, dass das Endprodukt den Anforderungen entspricht.

## Informieren

## Anforderungsanalyse
 
| An-№ | Typ      | Beschreibung                                     | 
| ---- | -------- | ------------------------------------------------ |
|   1   |    Funktional      |         Das Spiel soll eine einfache und präzise Steuerung von Pac-Man haben.                                |
|   2   |    Funktional      |            Das Spiel gibt eine Belohnung für das Sammeln von Punkten.                             |
|   3   |    Funktional      |                 Die Geister sollen unterschiedliche Bewegungsmuster haben.                        |
|  4    |    Funktional      |                Das Spiel soll verschiedene Kartenlayouts und Schwierigkeitsgrade haben.                         |
|   5   |    Funktional      |                Das Spiel soll ansprechende Musik und Soundeffekte haben.                         |
|  6    |    Qualität      |               Das Spiel soll eine Intuitive und leicht navigierbare UI haben.                          |
|    7  |    Funktional      |                   Das Spiel soll Power-ups haben, um temporäre Vorteile im Spiel zu haben.                      |
|   8   |    Funktional      |                Das Spiel soll eine Speicherung und Anzeige der besten Spielergebnisse und der Anzahl Coins haben.                 |




## User-Storys

| US-№ | An-№ | Verbindlichkeit | Beschreibung                 |
| ---- | ---- | --- | ---------------------------------- |
| 1.1    |   1   |  muss | Als User möchte ich die Richtung in die sich die Spielfigur bewegt nach oben, unten, rechts oder links ändern können, um mich auf der Map zu bewegen.  |
| 1.2    |   1   |  muss | Als User möchte ich, dass die Spielfigur die Bahn nicht verlassen kann, um das Spiel anspruchsvoller zu machen. |
| 2.1    |   2   |  muss | Als User möchte ich für die erreichte Punktzahl eine Belonung in Form von In-Game-Coins erhalten, um mir andere Skins für die Figur zu kaufen. |
| 3.1    |   3   |  muss | Als User möchte ich, dass zwei Geister direkt von vorne angreifen, um das Spiel zu anspruchsvoller zu machen.  |
| 3.2    |   3   |  muss | Als User möchte ich, dass ein Geist von hinten angreift, um das Spiel zu anspruchsvoller zu machen.  |
| 3.3    |   3   |  muss | Als User möchte ich, dass ein Geist aus verschiedenen Richtungen kommen kann, um das Spiel zu anspruchsvoller zu machen.  |
| 3.4    |   3   |  muss | Als User möchte ich, der Spieler bei einer Kollision mit eienm Geist stirbt, um dem Spiel ein Ende zu setzen.  |
| 3.5    |   3   |  muss | Als User möchte ich, dass gefressene Geister nach einer gewissen Zeit respawnend, um das Spiel zu anspruchsvoller zu machen.  |
| 4.1    |   4   |  muss | Als User möchte ich, drei verschiedene Maps zur Auswahl haben, um Abwechslung in das Spiel zu bringen.  |
| 4.2    |   4   |  muss | Als User möchte ich, drei verschiedene Schwierigkeitsgrade zur Auswahl haben, um das Spiel zu anspruchsvoller zu machen.  |
| 5.1    |   5   |  muss | Als User möchte ich, Hintergrundmusik im Spiel haben, um das Spiel zu unterhaltsamer zu machen.  |
| 5.2    |   5   |  muss | Als User möchte ich, einen Sound-Effect für den Tod der Spielfigur haben, um das Spiel zu unterhaltsamer zu machen.  |
| 5.3    |   5   |  muss | Als User möchte ich, einen Sound-Effect für während des Power-ups der Spielfigur haben, um das Spiel zu unterhaltsamer zu machen.  |
| 5.4    |   5   |  muss | Als User möchte ich, einen Sound-Effect für die Aktivierung des Power-ups haben, um das Spiel zu unterhaltsamer zu machen.  |
| 5.5    |   5   |  muss | Als User möchte ich, einen Sound-Effect für den Tod eines Geistes haben, um das Spiel zu unterhaltsamer zu machen.  |
| 7.1    |   7   |  muss | Als User möchte ich, in ein Item, welcher nach einer gewissen Zeit auf der Map spawnt, laufen könne, um das Power-Up zu aktiveren.  |
| 7.2    |   7   |  muss | Als User möchte ich, während der Power-Up-Zeit Geister fressen können, um die Geister vorübergehend zu töten.  |
| 8.1    |   8   |  muss | Als User möchte ich, dass der Highscore durchgehend angezeigt wird, um zu wissen wann ich ihn schlage.  |
| 8.2    |   8   |  muss | Als User möchte ich, dass der der Score der letzen runde im Main-Screen angezeigt wird, um die Information zu haben.  |
| 8.3    |   8   |  muss | Als User möchte ich, dass meine Anzahl Coins durchgehend angezeigt wird, um zu wissen wann ich mir einen Skin kaufen kann.  |


## Planen


## Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | PC ist gestartet | Applikation öffnen | Applikation öffnet sich. |
| 1.2  | Applikation ist geöffnet, Pac-Man ist auf der Map | Pfeiltasten nach oben, unten, rechts, links drücken | Pac-Man ändert die Richtung entsprechend der Eingabe. |
| 1.3  | Applikation ist geöffnet, Pac-Man ist am Rand der Bahn | Pfeiltaste drücken, um die Bahn zu verlassen | Pac-Man bleibt innerhalb der Bahn. |
| 2.1  | Pac-Man sammelt Punkte | Punkte sammeln | In-Game-Coins werden entsprechend der gesammelten Punkte gutgeschrieben. |
| 3.1  | Spiel ist gestartet, Geister sind auf der Map | Spiel läuft | Zwei Geister greifen direkt von vorne an. |
| 3.2  | Spiel ist gestartet, Geister sind auf der Map | Spiel läuft | Ein Geist greift von hinten an. |
| 3.3  | Spiel ist gestartet, Geister sind auf der Map | Spiel läuft | Ein Geist greift aus verschiedenen Richtungen an. |
| 3.4  | Pac-Man trifft auf einen Geist | Spiel läuft | Pac-Man stirbt bei der Kollision mit einem Geist. |
| 3.5  | Pac-Man hat einen Geist gefressen | Spiel läuft | Gefressener Geist respawnt nach einer bestimmten Zeit. |
| 4.1  | Applikation ist geöffnet | Drei verschiedene Maps zur Auswahl haben | Benutzer kann zwischen drei verschiedenen Maps wählen. |
| 4.2  | Applikation ist geöffnet | Drei verschiedene Schwierigkeitsgrade zur Auswahl haben | Benutzer kann zwischen drei verschiedenen Schwierigkeitsgraden wählen. |
| 5.1  | Applikation ist geöffnet | Spiel starten | Hintergrundmusik spielt während des Spiels. |
| 5.2  | Pac-Man stirbt im Spiel | Spiel läuft | Sound-Effekt für den Tod der Spielfigur wird abgespielt. |
| 5.3  | Pac-Man aktiviert ein Power-up | Spiel läuft | Sound-Effekt für die Aktivierung des Power-ups wird abgespielt. |
| 5.4  | Pac-Man hat ein Power-up | Spiel läuft | Sound-Effekt für die Power-up-Zeit wird abgespielt. |
| 5.5  | Pac-Man frisst einen Geist während des Power-ups | Spiel läuft | Sound-Effekt für den Tod des Geistes wird abgespielt. |
| 7.1  | Spiel ist gestartet, ein Power-up erscheint auf der Map | Pac-Man läuft in das Power-up | Power-up wird aktiviert. |
| 7.2  | Pac-Man hat ein aktives Power-up | Pac-Man trifft auf einen Geist | Pac-Man frisst den Geist und der Geist wird vorübergehend getötet. |
| 8.1  | Spiel ist gestartet | Spiel läuft | Highscore wird durchgehend angezeigt. |
| 8.2  | Spiel ist vorbei | Zum Main-Screen wechseln | Score der letzten Runde wird im Main-Screen angezeigt. |
| 8.3  | Spiel ist gestartet | Spiel läuft | Anzahl Coins wird durchgehend angezeigt. |

## Zeitplan

## Woche 1

### Dienstag, 14. Mai 2024

| Zeitblock | Geplante Aktivität | Tatsächliche Aktivität | Vergleich |
|:---------:|:------------------:|:----------------------:|:------------------:|
| 07:30-08:30 | Anforderungsanalyse | Anforderungsanalyse | ✔️ |
| 08:35-09:35 | User-Stories | User-Stories | ✔️ |
| 09:40-10:40 | Arbeitsjournal | Arbeitsjournal | ✔️ |
| 10:45-11:45 | Testfälle | Testfälle | ✔️ |

## Woche 2

### Dienstag, 21. Mai 2024

| Zeitblock | Geplante Aktivität | Tatsächliche Aktivität | Vergleich |
|:---------:|:------------------:|:----------------------:|:------------------:|
| 07:30-08:30 | Testfälle | Testfälle | ✔️ |
| 08:35-09:35 | Arbeitspacket | Arbeitspacket | ✔️ |
| 09:40-10:40 | Arbeitspacket | Arbeitspacket | ✔️ |
| 10:45-11:45 | Zeitplan | Zeitplan | ✔️ |

## Woche 3

### Dienstag, 28. Mai 2024

| Zeitblock | Geplante Aktivität | Tatsächliche Aktivität | Vergleich |
|:---------:|:------------------:|:----------------------:|:------------------:|
| 07:30-08:30 | Zeitplan | Zeitplan | ✔️ |
| 08:35-09:35 | Dokumentation | Dokumentation | ✔️ |
| 09:40-10:40 | Dokumentation | Dokumentation | ✔️ |
| 10:45-11:45 | Dokumentation | Dokumentation | ✔️ |

## Woche 4

### Dienstag, 04. Juni 2024

| Zeitblock | Geplante Aktivität | Tatsächliche Aktivität | Vergleich |
|:---------:|:------------------:|:----------------------:|:------------------:|
| 07:30-08:30 | Projektplanung | Projektplanung | ✔️ |
| 08:35-09:35 | Code-Entwicklung | Code-Entwicklung | ✔️ |
| 09:40-10:40 | Code-Überprüfung | Code-Überprüfung und Debugging | ❌ |
| 10:45-11:45 | Dokumentation | Dokumentation | ✔️ |

## Woche 5

### Dienstag, 11. Juni 2024

| Zeitblock | Geplante Aktivität | Tatsächliche Aktivität | Vergleich |
|:---------:|:------------------:|:----------------------:|:------------------:|
| 07:30-08:30 | Projektplanung | Projektplanung | ✔️ |
| 08:35-09:35 | Code-Entwicklung | Code-Entwicklung | ✔️ |
| 09:40-10:40 | Code-Überprüfung | Code-Überprüfung und Debugging | ❌ |
| 10:45-11:45 | Dokumentation | Dokumentation | ✔️ |

## Woche 6

### Dienstag, 18. Juni 2024

| Zeitblock | Geplante Aktivität | Tatsächliche Aktivität | Vergleich |
|:---------:|:------------------:|:----------------------:|:------------------:|
| 07:30-08:30 | Projektplanung | Projektplanung | ✔️ |
| 08:35-09:35 | Code-Entwicklung | Code-Entwicklung | ✔️ |
| 09:40-10:40 | Code-Überprüfung | Code-Überprüfung und Debugging | ❌ |
| 10:45-11:45 | Dokumentation | Dokumentation | ✔️ |

## Woche 7

### Dienstag, 24. Juni 2024

| Zeitblock | Geplante Aktivität | Tatsächliche Aktivität | Vergleich |
|:---------:|:------------------:|:----------------------:|:------------------:|
| 07:30-08:30 | Projektplanung | Projektplanung | ✔️ |
| 08:35-09:35 | Code-Entwicklung | Code-Entwicklung | ✔️ |
| 09:40-10:40 | Code-Überprüfung | Code-Überprüfung und Debugging | ❌ |
| 10:45-11:45 | Dokumentation | Dokumentation | ✔️ |

## 6. Projektumfeld

### 6.1 Systemgrenzen / Schnittstellen zur Aussenwelt
Das Projekt ist eingebettet in ein Umfeld, das verschiedene Systemgrenzen und Schnittstellen umfasst. Diese sind dokumentiert und umfassen:
- **Systemgrenzen:** Die Grenzen des Projekts sind durch die Anforderungen und Ziele des Pac-Man-Spiels definiert. Dazu gehört die Implementierung der Spielmechanik, Benutzeroberfläche, Musik und Soundeffekte sowie die Integration von Power-Ups und Highscore-Anzeigen.
- **Schnittstellen zur Aussenwelt:** Das Projekt interagiert mit verschiedenen externen Komponenten wie der Entwicklungsumgebung, Drittanbieter-Bibliotheken für Musik und Soundeffekte sowie Plattformen zur Verteilung und Veröffentlichung des Spiels.

### 6.2 Abgrenzung und Beschreibung des Auftragsumfelds
Der Kandidat kennt die Abgrenzung seines Auftrages zum Umfeld und kann dieses beschreiben. Allfällige Schnittstellen sind ihm im Detail bekannt und dokumentiert. Dazu gehört:
- **Entwicklungsumgebung:** Verwendung von Software-Tools und Entwicklungsplattformen, die für die Umsetzung des Spiels erforderlich sind.
- **Drittanbieter-Bibliotheken:** Integration von Bibliotheken für Musik, Soundeffekte und eventuell grafische Elemente.
- **Veröffentlichungsplattformen:** Planung der Veröffentlichung des Spiels auf geeigneten Plattformen wie Steam, App Store oder Google Play Store.

## 7. Arbeits- und Fachmethodik

### 7.1 Auswahl und Anwendung der Fachmethoden
Es wurden der jeweiligen Aufgabe entsprechend die richtigen Arbeits- und Fachmethoden korrekt angewendet. Dazu gehören:
- **Programmiersprachen:** Auswahl geeigneter Programmiersprachen (z.B. JavaScript, Python) für die Entwicklung des Spiels.
- **Entwicklungsumgebung:** Verwendung einer geeigneten IDE (Integrated Development Environment) zur effizienten Programmierung und Fehlersuche.
- **Versionskontrolle:** Einsatz von Versionskontrollsystemen (z.B. Git), um den Code zu verwalten und Änderungen nachzuverfolgen.
- **Testmethoden:** Anwendung von Testmethoden zur Überprüfung der Spielmechanik und zur Sicherstellung der Qualität (z.B. Unit-Tests, Integrationstests).
- **Dokumentation:** Detaillierte Dokumentation des Entwicklungsprozesses, der verwendeten Technologien und der durchgeführten Tests.

### 7.2 Vollständige Umsetzung der Methoden
Die ausgewählten Fachmethoden und Arbeitstechniken wurden korrekt angewandt und vollständig umgesetzt. Dies wird durch folgende Maßnahmen sichergestellt:
- **Regelmäßige Überprüfungen:** Regelmäßige Reviews und Code-Überprüfungen, um die Einhaltung der Methoden sicherzustellen.
- **Tests:** Umfassende Tests, um die Funktionalität und Qualität des Spiels zu gewährleisten.
- **Dokumentation:** Detaillierte und vollständige Dokumentation aller Arbeitsschritte, Entscheidungen und Ergebnisse.

## 8. Zusammenfassung und Ausblick
Das Projekt Pac-Man-Spiel wurde erfolgreich umgesetzt, wobei die IPERKA-Methode als Projektmanagement-Methode angewandt wurde. Alle Anforderungen wurden erfüllt und die Ergebnisse wurden dokumentiert. Der Entwicklungsprozess und die verwendeten Methoden wurden kontinuierlich überprüft und optimiert. Zukünftige Projekte können von den gewonnenen Erkenntnissen und Erfahrungen profitieren, um noch effizienter und effektiver durchgeführt zu werden.
