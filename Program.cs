using System;
using System.Threading;
using System.Linq;
using Random = System.Random;
using String = System.String;
namespace ConsoleApp1
{
    static class Jatek
    {
        public static void SzamJatek()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nSzabályok: \n10 próbálkozásod van, hogy kitaláld a számot 0 és 100 között. \nHa eltalálod a számot, gratulálunk! \nHa nem, akkor a program törli a systam mappádat (windows) vagy a root mappádat (linux)");
            Console.ForegroundColor = ConsoleColor.White;
            bool jatek = true;
            while (true)
            {
                int szam = Random.Shared.Next(0, 100);
                int probalkozasok = 10;
                Console.WriteLine("\nJöhet a kövi kör!");
                for (probalkozasok = 11; probalkozasok > 0; --probalkozasok)
                {
                    if (probalkozasok == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sajnos nem találtad el a számot!");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                    Console.WriteLine($"Add meg a tippedet, (még {probalkozasok - 1} probálkozasod van)!");
                    bool siker = false;
                    int tipp = 0;
                    while (!siker)
                    {
                        siker = int.TryParse(Console.ReadLine(), out tipp);
                        if (tipp > 101 || tipp < 0)
                        {
                            siker = false;
                        }
                    }
                    if (tipp == 101)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Köszönjük a játékot! A szám az {szam} volt. A program most bezárul.");
                        Thread.Sleep(3000);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine($"Éppen törlődnek a rendszerfájlaid!");
                            string betoltes = System.String.Concat(Enumerable.Repeat("██", i));
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write($"\nProgress: ");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write(betoltes);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Thread.Sleep(2000);
                            Console.Clear();
                        }
                        Console.BackgroundColor = ConsoleColor.Black;
                        Environment.Exit(101);
                    }
                    else if (tipp > szam)
                    {
                        if (tipp - szam >= 21)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"Még messze vagy! (Nagyobb a tipped)");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (tipp - szam >= 6)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine($"Már nem vagy olyan messze! (Nagyobb a tipped)");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (tipp - szam >= 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Nagyon közel vagy! (Nagyobb a tipped)");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    else if (tipp < szam)
                    {
                        if (szam - tipp >= 21)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"Még messze vagy! (Kisebb a tipped)");
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                        else if (szam - tipp >= 6)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine($"Már nem vagy olyan messze! (Kisebb a tipped)");
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                        else if (szam - tipp >= 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Nagyon közel vagy! (Kisebb a tipped)");
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                    }
                    else if (tipp == szam)
                    {
                        Console.WriteLine($"Gratulálunk! Eltaláltad a számot, ami {szam} volt!");
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    }
                    Thread.Sleep(2000);
                    Console.Clear();


                }
                Console.Clear();
                Console.WriteLine("Szeretnél tolni még egy menetet? i/n?");
                string karakter = Console.ReadLine();
                if (karakter == "n")
                {
                    Environment.Exit(0);
                }
                else
                {
                    continue;
                }
            }
        }





        static class Konzol
        {
            public static void Cim(string szoveg)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"═══ {szoveg} ═══");
                Console.ResetColor();
            }

            public static void Siker(string szoveg)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"✔ {szoveg}");
                Console.ResetColor();
            }

            public static void Hiba(string szoveg)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"✘ {szoveg}");
                Console.ResetColor();
            }

            public static void Menu(string szoveg, int sorszam = 0)
            {
                if (sorszam == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"{szoveg}");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($"{sorszam}. {szoveg}");
                    Console.ResetColor();
                }
            }
        }


        internal class Program
        {
            static void Main(string[] args)
            {
                int kor = 0;
                string nev = "";
                while (true)
                {
                    Konzol.Cim("Főmenü");
                    Konzol.Menu("Köszöntés: ", 1);
                    Konzol.Menu("Név bekérése: ", 2);
                    Konzol.Menu("Életkor bekérése: ", 3);
                    Konzol.Menu("Adatok kiírása: ", 4);
                    Konzol.Menu("Elköszönés: ", 5);
                    Konzol.Menu("Kilépés: ", 6);
                    Konzol.Menu("Választás:");
                    char valasztottMenupont = '0';
                    ConsoleKeyInfo menupont = Console.ReadKey(true);
                    valasztottMenupont = menupont.KeyChar;

                    switch (valasztottMenupont)
                    {
                        case '1':
                            Console.WriteLine("Üdvözlet a programunkban!");
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;

                        case '2':
                            Console.Write("Add meg a neved: ");
                            nev = Console.ReadLine();
                            Console.WriteLine($"Üdvözöllek, {nev}!");
                            Console.Clear();
                            break;

                        case '3':
                            Console.Write("Add meg az életkorod: ");
                            bool siker = false;
                            while (!siker)
                            {
                                siker = int.TryParse(Console.ReadLine(), out kor);
                                if (kor > 110 || kor < 0)
                                {
                                    siker = false;
                                }
                            }
                            Console.WriteLine($"Az életkorod: {kor}");
                            Console.Clear();
                            break;

                        case '4':
                            if (!string.IsNullOrEmpty(nev) && kor > 0)
                            {
                                Console.WriteLine("\nA megadott adatok:");
                                Console.WriteLine($"Név: {nev}");
                                Console.WriteLine($"Életkor: {kor}");
                            }
                            else
                            {
                                Console.WriteLine("Kérlek, adj meg minden adatot!");
                            }
                            Console.Clear();
                            break;

                        case '5':
                            Console.WriteLine("Köszönjük a használatot!");
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;

                        case '6':
                            Console.WriteLine("Kilépés...");
                            Environment.Exit(0);
                            Console.Clear();
                            break;

                        case '7':
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("\nTitkos menüpont! Találd ki a számot 0 és 100 között!");
                            Console.ForegroundColor = ConsoleColor.White;
                            SzamJatek();
                            Console.Clear();
                            break;

                        default:
                            Console.WriteLine("ILYEN OPCIÓD NINCSEN!");
                            Console.Clear();
                            break;
                    }
                }
            }
        }
    }
}
