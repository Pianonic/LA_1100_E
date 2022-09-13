# Projekt-Dokumentation

Erismann Niclas

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
|   23.08.2022    | 0.0.9   | "4 Realisieren" angefangen.                                  |
|   30.08.2022    | 0.1.0   | "2 Planen" überarbeitet.                                     |
|   30.08.2022    | 0.1.1   | "1.2 User Stories" überarbeitet.                             |
|   30.08.2022    | 0.1.2   | "1.3 Testfälle" überarbeitet.                                |
|   30.08.2022    | 0.1.3   | "5.1 Testfälle" angefangen.                                  |
|   30.08.2022    | 0.1.4   | "4 Realisieren" fertig.                                      |
|   06.09.2022    | 0.1.5   | "1.2 User Stories" überarbeitet.                             |
|   06.09.2022    | 0.1.5   | "1.3 Testfälle" überarbeitet.                                |
|   13.09.2022    | 0.1.6   | Alles fertig ausgefüllt und überarbeitet.                    |

## 1 Informieren

### 1.1 Ihr Projekt

Ein Spiel, in welchem der User eine vom Programm zufällig generierte zahl erraten muss.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ         | Beschreibung                                                                                                        |
| ---- | --------------- | ----------- | ------------------------------------------------------------------------------------------------------------------- |
| 1    |       Muss      |  Funktional | Als Programierer möchte ich ein Programm kreieren, welches mit fehlereingaben zurecht kommt.                        |
| 2    |       Muss      |  Funktional | Als Spieler möchte ich eine Zahl erraten, damit ich spass habe.                                                     |
| 3    |       Muss      |  Funktional | Als Spieler möchte ich wissen, ob meine Zahl grösser oder kleiner als die generierte Zahl ist.                      |
| 4    |       Muss      |  Funktional | Als Spieler möchte ich eine gratulation, falls ich die Zahl herausgefunden habe.                                    |
| 5    |       Muss      |  Funktional | Als Spieler möchte ich am ende einer Runde sehen, wie veiele Versuche ich hatte.                                    |
| 6    |       Muss      |  Funktional | Als Spieler möchte ich entscheiden können, ob ich eine neue Rude beginnen will oder das Programm schliessen will.   |
| 7    |       Kann      |  Qualität   | Als Spieler möchte ich ein schönes Konsolen Interface mit farben sehen.                                             |
| 8    |       Kann      |  Funktional | Als Spieler möchte meine Zahlenspanne selbst eintscheiden.                                                          |
| 9    |       Kann      |  Funktional | Als Spieler möchte ich zwischen 2 verschiedenen schwierigkeitsstufen entscheiden können oder einen eigenen wert eingeben. |

### 1.3 Testfälle

| TC-№ | Ausgangslage                                                      | Eingabe                                | Erwartete Ausgabe                    |
| ---- | ----------------------------------------------------------------- | -------------------------------------  | ------------------------------------ |
| 1.1  | Zahl wurde generiert und wartet auf User Input.                   | "fünfundfünfzig"                       | "Dies ist keine gültige Zahl!"       |
| 1.2  | Zahl wurde generiert und wartet auf User Input.                   | "Das ist ein Test"                     | "Dies ist keine gültige Zahl!"       |
| 2.1  | Zahl wurde generiert und wartet auf User Input.                   | "20"                                   | "Du hast die Zahl richtig erraten"   |
| 3.1  | Zahl wurde generiert und wartet auf User Input.                   | "40"                                   | "Deine Zahl ist zu Gross / zu Klein" |
| 4.1  | Zahl wurde generiert und wartet auf User Input.                   | "20"                                   | "Gratulation du hast es geschafft" |
| 5.1  | Spiel wurde bendet.                                               | -                                      | "Du hast (AnzVersuche) Versuche gebraucht." |
| 6.1  | Frage wurde gestellt und wartet auf user Input.                   | True / False                           | True = "Super Spiel wird neu getstartet!" False = "Schade ;)"   |
| 7.1  | Programm wurde ausgeführt.                                        | "Nichts"                               | ![Bild](https://user-images.githubusercontent.com/79938743/188586636-30d68380-6ef1-48fc-8fef-1039e8416c92.png) |
| 8.1  | Begrüssung wurde gezeigt, fragt nach dem minimal und maximal wert und wartet auf User Input.   | "1" & "40"     | ***Programm startet mit einer Custom Zahl.*** |
| 9.1  | Begrüssung wurde gezeigt, fragt nach schwierigkeitsstufe oder ob man slbst eine eingeben will.   | "easy"   | ***Programm wechselt in den Modus.*** |

### 1.4 Diagramme



![Bild](https://github.com/Pianonic/LA_1100_E/blob/main/Screenshots/Zuf%C3%A4llige%20Zahlen.png?raw=true)

## 2 Planen

| AP-№ | Frist       | Zuständig | Beschreibung                          | geplante Zeit |
| ---- | ----------- | --------- | ------------------------------------  | ------------- |
| 1.A  |  23.08.2022 | Ich       | Den Ablauf kreiren                    | 20 Minuten    |
| 2.A  |  10.08.2022 | Ich       | Programmieren                         | 2 Stunden     |
| 2.A  |  10.08.2022 | Ich       | Code nach PAP überarbeiten            | 1 Stunde      |
| 3.A  |  10.08.2022 | Ich       | Projektdokumentation                  | 2 Stunde      |
| 4.A  |  10.08.2022 | Ich       | Code nach PAP überarbeiten            | 1 Stunde      |
| 5.A  |  10.08.2022 | Ich       | Code nach PAP überarbeiten            | 1 Stunde      |

Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.


## 4 Realisieren

| AP-№ | Datum      | Zuständig | geplante Zeit                         | tatsächliche Zeit |
| ---- | ---------- | --------- | ------------------------------------- | ----------------- |
| 1.A  | 23.08.2022 | Ich       | Den Ablauf kreiren                    | 5 Minuten         |
| 2.A  | 30.08.2022 | Ich       | Programmiern                          | 40 Minuten        |
| 2.A  | 30.08.2022 | Ich       | Code nach PAP überarbeiten            | 50 Minuten        |
| 3.A  | 10.08.2022 | Ich       | Projektdokumentation                  | 2 Stunden         |
| 3.A  | 06.09.2022 | Ich       | Projektdokumentation                  | 2 Stunden         |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum      | Resultat                                                | Tester    |
| ---- | ---------- | ------------------------------------------------------- | --------- |
| 1.9  | 13.08.2022 | Funktioniert                                            | Ich       |
| 1.1  | 13.08.2022 | Funktioniert                                            | Ich       |
| 1.2  | 13.08.2022 | Funktioniert                                            | Ich       |
| 2.1  | 13.08.2022 | Funktioniert                                            | Ich       |
| 3.1  | 13.08.2022 | Funktioniert                                            | Ich       |
| 4.1  | 13.08.2022 | Funktioniert                                            | Ich       |
| 5.1  | 13.08.2022 | Funktioniert, Aber falsches Resultat                    | Ich       |
| 6.1  | 13.08.2022 | Funktioniert                                            | Ich       |
| 7.1  | 13.08.2022 | Funktioniert                                            | Ich       |
| 8.1  | 13.08.2022 | Funktioniert                                            | Ich       |

Fazit: 

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage                                 | Eingabe                | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | -------------------------------------------- | ---------------------- | ----------------- | -------------------- |
| I    | Bei True/Flase soll Programm Neustarten      |   Eine Zahl            |  Nicht gültige Eingabe |            Ungültige Zahl und hat nur noch ungültige Zahl ausgegeben und hat auch bei einer richtigen Eingabe falsch reagiert          |

Liam Gideon Koch

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
