# Lern-Bericht
Erismann Niclas

## Einleitung

In diesem Projekt habe ich ein Programm erstellt bei welchem man eine Zufallszahl erraten muss.

## Was habe ich gelernt?

Ich habe gelernt wie man mit Farbe ein Konsolenprogramm Schöner machen und einen Titel am Anfang einfügen kann.

## Beschreibung

Als ich bei einem Kollegen aus der Parallelklasse gesehen habe, dass er sein Programm mit Farben verschönert hatte, wollte ich das unbedingt auch machen. Ausserdem habe ich bei vielen YouTube Videos gesehen, dass Leute ihr Konsolen Programme mit Titeln Verschönern. Also habe ich mich auf die suche begeben um heraus zu finden wie man so etwas macht jedoch ohne Erfolg. Irgendwann gab ich jedoch auf weil ich nichts fand und öffnete TikTok. Nach einigen Minuten passierte jedoch etwas unerwartetes. Ein [TikToker](https://www.tiktok.com/@icode4u/video/7139112401491774725?_r=1&_t=8VTwHiaIo3K&is_from_webapp=v1&item_id=7139112401491774725) zeigte eine Webseite auf welcher man genau solche ASCII Titel machte und ich war überglücklich aber auch schockiert. Ist das ein Zeichen das wir beobachtet werden?! Ich habe die [Webseite](http://patorjk.com/software/taag/#p=display&f=Graffiti&t=Type%20Something%20) geöffnet einen Titel gemacht und war glücklich.

![Bild](https://github.com/Pianonic/LA_1100_E/blob/main/Screenshots/Animation.gif)
![Bild](https://github.com/Pianonic/LA_1100_E/blob/main/Screenshots/Screenshot%202022-09-13%20102753.png?raw=true)

Hier ist der Code vom obigem Bild:

```csharp
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\r\n  ____              _     _          _         _____         _     __  \r\n |  _ \\  __ _ ___  (_)___| |_    ___(_)_ __   |_   _|__  ___| |_   \\ \\ \r\n | | | |/ _` / __| | / __| __|  / _ \\ | '_ \\    | |/ _ \\/ __| __| (_) |\r\n | |_| | (_| \\__ \\ | \\__ \\ |_  |  __/ | | | |   | |  __/\\__ \\ |_   _| |\r\n |____/ \\__,_|___/ |_|___/\\__|  \\___|_|_| |_|   |_|\\___||___/\\__| ( ) |\r\n                                                                  |/_/ \r\n");
        }
    }
}

```

Wenn man RGB mag dem wird auch das gefallen. ;)

![bild3](https://github.com/Pianonic/LA_1100_E/blob/main/Screenshots/ezgif-2-d541ef824d.gif?raw=true)

```csharp
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Titel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            while (x == 1)
            {
                Console.BackgroundColor = ConsoleColor.Red; // Hier wird der Hintergrund auf Rot Gesetzt.
                Console.WriteLine("\r\n  ____              _     _          _         _____         _     __  \r\n |  _ \\  __ _ ___  (_)___| |_    ___(_)_ __   |_   _|__  ___| |_   \\ \\ \r\n | | | |/ _` / __| | / __| __|  / _ \\ | '_ \\    | |/ _ \\/ __| __| (_) |\r\n | |_| | (_| \\__ \\ | \\__ \\ |_  |  __/ | | | |   | |  __/\\__ \\ |_   _| |\r\n |____/ \\__,_|___/ |_|___/\\__|  \\___|_|_| |_|   |_|\\___||___/\\__| ( ) |\r\n                                                                  |/_/ \r\n"); // DAs ist der Titel
                Thread.Sleep(100); // Hier werden 100 Millisekunden gewartet.
                Console.Clear(); // Hier wird die Konsole gelöscht.
                Console.BackgroundColor = ConsoleColor.Green; // Hier wird der Hintergrund auf Grün Gesetzt.
                Console.WriteLine("\r\n  ____              _     _          _         _____         _     __  \r\n |  _ \\  __ _ ___  (_)___| |_    ___(_)_ __   |_   _|__  ___| |_   \\ \\ \r\n | | | |/ _` / __| | / __| __|  / _ \\ | '_ \\    | |/ _ \\/ __| __| (_) |\r\n | |_| | (_| \\__ \\ | \\__ \\ |_  |  __/ | | | |   | |  __/\\__ \\ |_   _| |\r\n |____/ \\__,_|___/ |_|___/\\__|  \\___|_|_| |_|   |_|\\___||___/\\__| ( ) |\r\n                                                                  |/_/ \r\n"); // DAs ist der Titel
                Thread.Sleep(100); // Hier werden 100 Millisekunden gewartet.
                Console.Clear(); // Hier wird die Konsole gelöscht.
                Console.BackgroundColor = ConsoleColor.Blue; // Hier wird der Hintergrund auf Blau Gesetzt.
                Console.WriteLine("\r\n  ____              _     _          _         _____         _     __  \r\n |  _ \\  __ _ ___  (_)___| |_    ___(_)_ __   |_   _|__  ___| |_   \\ \\ \r\n | | | |/ _` / __| | / __| __|  / _ \\ | '_ \\    | |/ _ \\/ __| __| (_) |\r\n | |_| | (_| \\__ \\ | \\__ \\ |_  |  __/ | | | |   | |  __/\\__ \\ |_   _| |\r\n |____/ \\__,_|___/ |_|___/\\__|  \\___|_|_| |_|   |_|\\___||___/\\__| ( ) |\r\n                                                                  |/_/ \r\n"); // DAs ist der Titel
                Thread.Sleep(100); // Hier werden 100 Millisekunden gewartet.
                Console.Clear(); // Hier wird die Konsole gelöscht.
            }
        }
    }
}

```

## Verifikation

Im Text wird beschrieben wie ich vorgegangen bin, im gif sieht man wie die Webseite funktioniert und auf dem Bild wie man wie es in der Konsole aussieht.

# Reflektion zum Arbeitsprozess

Einfach war die Farbe zu implementieren.
Schwierig war eine Webseite zu finden, welche ein ASCII Titel macht.

**VBV**: ✍️ Formulieren Sie davon ausgehend einen *handelbaren* Verbesserungsvorschlag.
