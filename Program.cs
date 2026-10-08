namespace ConsoleApp1
{
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
    }


    internal class Program
    {
        static void Main(string[] args)
        {   // 1. Feladat.
            Console.WriteLine("Add meg a korodat: ");
            int kor = Convert.ToInt32(Console.ReadLine());
            if (kor <= 17)
            {
                Console.WriteLine($"Még nem vagy nagykorú! {18 - kor} év múlva leszel nagykorú.");
            }
            else
            {
                Console.WriteLine("Már nagykorú vagy!");
            }
            // 2. Feladat.
            Console.WriteLine("Adj meg egy egész számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            string ternary = (szam % 2 == 0) ? "páros" : "páratlan";
            Console.WriteLine($"Ez a szám {ternary}.");
            //3. Feladat.
            Console.WriteLine("Adj meg egy jelszót: ");
            string jelszo = Console.ReadLine();
            ternary = (jelszo == "tengerpart") ? "Belépés engedélyezve." : "Hibás jelszó.";
            if (ternary == "Belépés engedélyezve.")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(ternary);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ternary);
                Console.ForegroundColor = ConsoleColor.White;
            }
            // 4. Feladat.
            Console.WriteLine("Add meg a rendelés értékét: ");
            int rendelesErtek = Convert.ToInt32(Console.ReadLine());
            ternary = (rendelesErtek >= 15000) ? "Ingyenes szállítás." : "Szállítási díj: 1490 Ft.";
            if (rendelesErtek >= 15000)
            {
                Console.WriteLine($"A küldeményedet ingyenesen szállítjuk! Végösszeg: {rendelesErtek:N2} Ft.");
            }
            else
            {
                Console.WriteLine($"A küldeményed szállítási díja: 1490 Ft. Végösszeg: {rendelesErtek + 1490:N2} Ft.");
            }
            // 5. Feladat.
            Console.WriteLine("Adj meg 2 (akár tört) számot, egymás után, enterrel elválasztva: ");
            double szam1 = Convert.ToDouble(Console.ReadLine());
            double szam2 = Convert.ToDouble(Console.ReadLine());
            ternary = (szam1 > szam2) ? $"A nagyobb szám: {szam1}" : (szam1 < szam2) ? $"A nagyobb szám: {szam2}" : "A két szám egyenlő.";
            Console.WriteLine(ternary);
            // 6. Feladat.
            Console.WriteLine("Kérled adj meg egy egész számot: ");
            while (true)
            {
                if (true == int.TryParse(Console.ReadLine(), out int szam3))
                {
                    Console.WriteLine($"A szám duplája: {szam3 * 2}, a négyzete pedig: {szam3 * szam3}");
                    break;
                }
                else
                {   
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ez nem egy egész szám! Kérlek adj meg egy egész számot: ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            //7. Feladat.
            Console.WriteLine("Kérlek add meg a kinti hőmérsékletet Celsiusban: ");
            double homerseklet = Convert.ToDouble(Console.ReadLine());
            if (homerseklet < 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Fagy van.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (homerseklet >= 0 && homerseklet <= 15)
            {
                Console.WriteLine("Hűvös van.");
            }
            else if (homerseklet > 15 && homerseklet <= 25)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Kellemes az idő.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Meleg van."); 
                Console.ForegroundColor = ConsoleColor.White;
            }
            //8. Feladat.
            int osztalyzat = 0;
            while (true)
            {
                Console.WriteLine("Kérlek add meg az osztályzatot (1-5): ");
                if (true == int.TryParse(Console.ReadLine(), out osztalyzat) && osztalyzat >= 1 && osztalyzat <= 5)
                {
                    switch (osztalyzat)
                    {
                        case 1:
                            Console.WriteLine("Elégtelen");
                            break;
                        case 2:
                            Console.WriteLine("Elégséges");
                            break;
                        case 3:
                            Console.WriteLine("Közepes");
                            break;
                        case 4:
                            Console.WriteLine("Jó");
                            break;
                        case 5:
                            Console.WriteLine("Jeles");
                            break;
                    }
                    break;
                }
                else
                {
                    Konzol.Hiba("Hibás osztályzat! Kérlek adj meg egy 1-5 közötti számot.");
                }
            }
            //9. Feladat.
            Console.WriteLine("Add meg hány pontos a dolgozatod (0-100): ");
            if (!int.TryParse(Console.ReadLine(), out int pontszam))
            {
                Konzol.Hiba("Hibás bevitel — egész számot adj meg.");
            }
            else
            {
                switch (pontszam)
                {
                    case >= 0 and <= 39:
                        Console.WriteLine("Elégtelen");
                        break;
                    case >= 40 and <= 54:
                        Console.WriteLine("Elégséges");
                        break;
                    case >= 55 and <= 69:
                        Console.WriteLine("Közepes");
                        break;
                    case >= 70 and <= 84:
                        Console.WriteLine("Jó");
                        break;
                    case >= 85 and <= 100:
                        Console.WriteLine("Jeles");
                        break;
                    default:
                        Konzol.Hiba("Az értéknek 0 és 100 közé kell esnie.");
                        break;
                }
            }
            //10. Feladat.
            Console.WriteLine("Adj meg egy hónapot (1-12): ");
            int honap = Convert.ToInt32(Console.ReadLine());
            switch (honap)
            {
                case 1:
                    Console.WriteLine($" A Január 31 napos");
                    break;
                case 2:
                    Console.WriteLine("A Február 28 napos");
                    break;
                case 3:
                    Console.WriteLine("A Március 31 napos");
                    break;
                case 4:
                    Console.WriteLine("Az Április 30 napos");
                    break;
                case 5:
                    Console.WriteLine("A Május 31 napos");
                    break;
                case 6:
                    Console.WriteLine("A Június 30 napos");
                    break;
                case 7:
                    Console.WriteLine("A Július 31 napos");
                    break;
                case 8:
                    Console.WriteLine("Az Augusztus 31 napos");
                    break;
                case 9:
                    Console.WriteLine("A Szeptember 30 napos");
                    break;
                case 10:
                    Console.WriteLine("Az Október 31 napos");
                    break;
                case 11:
                    Console.WriteLine("A November 30 napos");
                    break;
                case 12:
                    Console.WriteLine("A December 31 napos");
                    break;
                default:
                    Konzol.Hiba("Hibás hónap! Kérlek adj meg egy 1-12 közötti számot.");
                    break;
            }
            //11. Feladat.
            Console.WriteLine("Add meg az életkorodat: ");
            kor = Convert.ToInt32(Console.ReadLine());
            switch (kor)
            {
                case >= 0 and <= 5: 
                    Console.WriteLine("A belépőjegy ingyenes."); 
                    break;
                case >= 6 and <= 17:
                    Console.WriteLine("A belépőjegy ára: 1500 Ft. (diák)");
                    break;
                case >= 18 and <= 64:
                    Console.WriteLine("A belépőjegy ára: 2800 Ft. (felnőtt)");
                    break;
                case >= 65 and <= 120:
                    Console.WriteLine("A belépőjegy ára: 2000 Ft. (nyugdíjas)");
                    break;
                default:
                    Konzol.Hiba("Az életkor nem megfelelő! Kérlek adj meg egy 0 és 120 közötti életkort.");
                    break;
            }
            //12. Feladat.
            Console.WriteLine("Adj meg EGY darab betűt (A-Z) (angol abc): ");
            char betu = Convert.ToChar(Console.ReadLine().ToUpper());
            switch (betu){ 
                case 'A' or 'E' or 'I' or 'O' or 'U':
                Console.WriteLine($"A(z) {betu} magánhangzó.");
                break;
            }
        }
    }
}
