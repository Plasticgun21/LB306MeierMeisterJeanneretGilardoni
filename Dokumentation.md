# LB306MeierMeisterJeanneretGilardoni


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



## Testfälle

### TF-№: 1.1.1
US-№: 1.1
Ausgangslage: Spielfigur an Abzweigung nach links angekommen

Input: 1. 'ArrowLeft'
Output: 2. Spielfigur ändert Richtung nach links

### TF-№: 1.1.2
US-№: 1.1
Ausgangslage: Spielfigur an Abzweigung nach rechts angekommen
Input: 1. 'ArrowRight'
Output: 2. Spielfigur ändert Richtung nach rechts

### TF-№: 1.1.3
US-№: 1.1
Ausgangslage: Spielfigur an Abzweigung nach oben angekommen
Input: 1. 'ArrowUp'
Output: 2. Spielfigur ändert Richtung nach oben

### TF-№: 1.1.4
US-№: 1.1
Ausgangslage: Spielfigur an Abzweigung nach unten angekommen
Input: 1. 'ArrowDown'
Output: 2. Spielfigur ändert Richtung nach unten

### TF-№: 1.2.1
US-№: 1.2
Ausgangslage: Spiel gestartet + keine Verzweigung
Input: 'ArrowRight'
Output: -

### TF-№: 
US-№: 
Ausgangslage: 
Input: 
Output: 

### TF-№: 
US-№: 
Ausgangslage: 
Input: 
Output: 
