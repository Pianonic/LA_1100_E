# Projekt-Dokumentation

☝️ Alle Text-Stellen, welche mit einem ✍️ beginnen, können Sie löschen, sobald Sie die entsprechende Stellen ausgefüllt haben.

Erismann

| Datum           | Version | Zusammenfassung                                              |
| --------------- | ------- | ------------------------------------------------------------ |
|   23.08.2022    | 0.0.1   | "1.1 Ihr Projekt" fertig                                     |
|   23.08.2022    | 0.0.2   | "1.2 User Stories" anggefangen.                              |
|   23.08.2022    | 0.0.3   | "1.4 Diagramme" fertig.                                      |
|   23.08.2022    | 0.0.4   | "1.3 Testfälle" angefangen.                                  |
|   23.08.2022    | 0.0.5   | "1.2 User Stories" fertig.                                   |
|   23.08.2022    | 0.0.6   | "1.3 Testfälle" fertig.                                      |
|   23.08.2022    | 0.0.7   | "2 Planen" angefangen.                                       |
|   23.08.2022    | 0.0.8   | "1.2 User Stories" überarbeitet.                             |
|   23.08.2022    | 0.0.9   | ...                                                          |

## 1 Informieren

### 1.1 Ihr Projekt

Ein Spiel, in welchem der User eine vom Programm zufällig generierte zahl erraten muss.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ         | Beschreibung                                                                                                        |
| ---- | --------------- | ----------- | ------------------------------------------------------------------------------------------------------------------- |
| 1    |       Muss      |  Funktional | Als Programierer möchte ich zuerst einen Ablaufplan (PAP) kreiren, damit ich meinen Code darauf Aufbauen kann.      |
| 2    |       Muss      |  Funktional | Als Programierer möchte ich ein Programm kreieren, damit ich eine Zufällige Zahl erhalte.                           |
| 3    |       Muss      |  Funktional | Als Spieler möchte ich eine zahl erraten, damit ich spass habe.                                                     |
| 4    |       Muss      |  Funktional | Als Spieler möchte ich wissen, ob meine zahl grösser oder kleiner als die generierte zahl ist.                      |
| 5    |       Muss      |  Funktional | Als Spieler möchte ich eine gratulation, falls ich die Zahl herausgefunden habe.                                    |

✍️ Jede User Story hat eine ganzzahlige Nummer (1, 2, 3 etc.), eine Verbindlichkeit (Muss oder Kann?), und einen Typ (Funktional, Qualität, Rand). Die User Story selber hat folgende Form: *Als ein 🤷‍♂️ möchte ich 🤷‍♂️, damit 🤷‍♂️*.

### 1.3 Testfälle

| TC-№ | Ausgangslage                               | Eingabe                                | Erwartete Ausgabe                    |
| ---- | ------------------------------------------ | -------------------------------------  | ------------------------------------ |
| 1.1  | Ich möchte eine eine Planung erstellen.    | Im PAPDesigner einen ablauf erstellen. | Einen brauchbaren ablauf.            |
| 2.1  | Ich möchte eine zufalls Zahl generieren.   | Die zufällige Zahl generieren.         | Programm speichert die zufalls Zahl. |
| 3.1  | Ich möchte eine zufalls Zahl erraten.      | Ich gebe eine Zahl ein.                | Du hast die Zahl richtig erraten.    |
| 4.1  | Ich möchte eine rückmeldung erhalten.      | Ich gebe eine Zahl ein.                | Deine Zahl ist zu Gross / zu Klein.  |
| 5.1  | Ich möchte eine gratulation erhalten.      | Ich gebe eine Zahl ein.                | Gratulation du hast es geschafft.    |

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme

✍️ Hier können Sie PAPs, Use Case- und Gantt-Diagramme oder Ähnliches einfügen.
![Bild](https://github.com/Pianonic/LA_1100_E/blob/main/Screenshots/Zuf%C3%A4llige%20Zahl.png?raw=true)

## 2 Planen

| AP-№ | Frist       | Zuständig | Beschreibung                          | geplante Zeit |
| ---- | ----------- | --------- | ------------------------------------  | ------------- |
| 1.A  |  23.08.2022 |           | Den Ablauf kreiren                    | 20 Minuten    |
| 2.A  |             |           | Programmieren                         | 5 Stunden     |

Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit                         | tatsächliche Zeit |
| ---- | ----- | --------- | ------------------------------------- | ----------------- |
| 1.A  |       |           | Den Ablauf kreiren                    | 5 Minuten         |
| 2.A  |       |           |                                       |                   |
✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
