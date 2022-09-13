using System;

namespace LA1001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Konsolen groesse
            Console.SetWindowSize(170, 15);
            //--

            //Setup
            int Zahl = 0;
            string Schwierigkeitsgrad;

            // Play Again
            bool PGAG = false;
            //--

            int min = 1;
            int max = 100;

            int x = 0;
            int y = 0;
            int z = 0;
            int b = 1; //loop

            int AnzVersuche = 0;

            while (b == 1)
            {



                Random zufaellig = new Random();


                //Begrüssung
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("\r\n __          ___ _ _ _                                          _          _    _____                       _   _            _   _                 _               _ \r\n \\ \\        / (_) | | |                                        | |        (_)  / ____|                     | | | |          | \\ | |               | |             | |\r\n  \\ \\  /\\  / / _| | | | _____  _ __ ___  _ __ ___   ___ _ __   | |__   ___ _  | |  __ _   _  ___  ___ ___  | |_| |__   ___  |  \\| |_   _ _ __ ___ | |__   ___ _ __| |\r\n   \\ \\/  \\/ / | | | | |/ / _ \\| '_ ` _ \\| '_ ` _ \\ / _ \\ '_ \\  | '_ \\ / _ \\ | | | |_ | | | |/ _ \\/ __/ __| | __| '_ \\ / _ \\ | . ` | | | | '_ ` _ \\| '_ \\ / _ \\ '__| |\r\n    \\  /\\  /  | | | |   < (_) | | | | | | | | | | |  __/ | | | | |_) |  __/ | | |__| | |_| |  __/\\__ \\__ \\ | |_| | | |  __/ | |\\  | |_| | | | | | | |_) |  __/ |  |_|\r\n     \\/  \\/   |_|_|_|_|\\_\\___/|_| |_| |_|_| |_| |_|\\___|_| |_| |_.__/ \\___|_|  \\_____|\\__,_|\\___||___/___/  \\__|_| |_|\\___| |_| \\_|\\__,_|_| |_| |_|_.__/ \\___|_|  (_)\r\n                                                                                                                                                                     \r\n                                                                                                                                                                     \r\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                //--

                //Schwierigkeitsgrad aussuchen
                y = 1;
                while (y == 1)
                {
                    Console.WriteLine("Wähle Schwierigkeitsgrad: | easy | hard | custom");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Schwierigkeitsgrad = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;

                    if (Schwierigkeitsgrad == "easy")
                    {
                        Console.Clear();

                        y = 0;
                        x = 1;
                        z = 0;
                        Console.SetWindowSize(40, 20);
                    }
                    else if (Schwierigkeitsgrad == "hard")
                    {
                        Console.Clear();

                        y = 0;
                        x = 1;
                        z = 1;
                        Console.SetWindowSize(40, 20);

                    }
                    else if (Schwierigkeitsgrad == "custom")
                    {
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Wähle eine Maximal Zahl:");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;

                        int tmploop = 1;
                        while (tmploop == 1)
                        {
                            try
                            {
                                max = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();
                                y = 0;
                                x = 1;
                                z = 0;
                                Console.SetWindowSize(40, 20);
                                tmploop = 0;
                            }
                            catch
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.WriteLine("Dies ist keine gültige Zahl!");
                                Console.BackgroundColor = ConsoleColor.Black;
                            }
                        }

                    }


                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Dies ist kein gültiger Modus!");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                }

                //Random Beschreiben
                int rand_num = zufaellig.Next(min, max);
                //--

                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Wähle eine Zahl zwischen " + min + " - " + max + " aus.");
                Console.BackgroundColor = ConsoleColor.Black;

                while (x == 1)
                {

                    try
                    {



                        Console.WriteLine("  Welche Zahl ist die Richtige? ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Zahl = Convert.ToInt32(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.White;

                        if (Zahl < (max + 1))
                        {

                            if (Zahl > rand_num)
                            {
                                if (z == 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("  Zahl zu gross!");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    AnzVersuche = AnzVersuche + 1;
                                }
                                else if (z == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("  Die Zahl ist noch nicht korrekt!");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    AnzVersuche = AnzVersuche + 1;
                                }

                            }
                            else if (Zahl < rand_num)
                            {
                                if (z == 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("  Zahl zu klein!");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else if (z == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("  Die Zahl ist noch nicht korrekt!");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            }
                            else if (Zahl == rand_num)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Das ist die Richtige Zahl!");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("Du hattest " + AnzVersuche + " Versuche gebraucht.");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("lust auf noch eine Runde? true|false");
                                PGAG = Convert.ToBoolean(Console.ReadLine());

                                if (PGAG == true)
                                {
                                    Console.SetWindowSize(170, 15);
                                    x = 0;
                                    y = 0;
                                    z = 0;
                                    b = 1;
                                    max = 100;
                                    AnzVersuche = 0;

                                    Console.Clear();
                                }
                                else if (PGAG == false)
                                {
                                    Console.WriteLine("Schade ;)");

                                    x = 0;
                                    y = 0;
                                    z = 0;
                                    b = 0;
                                }

                            }

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("Deine Eingegebene Zaht ist über " + max + " !");
                            Console.BackgroundColor = ConsoleColor.Black;

                        }

                    }
                    catch
                    {

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Dies ist keine gültige Zahl!");
                        Console.BackgroundColor = ConsoleColor.Black;

                    }


                }
            }
        }
    }
}
