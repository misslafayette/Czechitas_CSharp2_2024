namespace Lesson2lecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vynimky1();  // výnimky výklad

            double cislo1 = 10.0;
            double cislo2 = 0.0;

            // Console.WriteLine($"Výsledok delenia je {cislo1 / cislo2}.");

            BezpecneDelenie podel = new BezpecneDelenie();

            try
            {
                podel.PodelCisla(cislo1, cislo2);
            }
            catch (Exception vynimka)
            {
                Console.WriteLine(vynimka);
            }
            Console.ReadLine();
        }

        private static void Vynimky1()
        {
            // PracaSCasom();  // výklad DateTime

            // užívateľ zadá dva integery a nechá si ich vydeliť
            Console.WriteLine("Zadaj prvé číslo:");
            string vstup = Console.ReadLine();

            int cislo1;
            try
            {
                cislo1 = int.Parse(vstup);
            }
            catch (OverflowException vynimka)
            {
                // Console.WriteLine("Nezadal si správny vstup.");

                Console.WriteLine("Číslo je príliš veľké.");
                Console.WriteLine("Ukončujem program.");
                Console.ReadLine();
                return;
            }
            catch (FormatException vynimka)
            {
                Console.WriteLine("Zadal si nesprávny formát čísla.");
                Console.ReadLine();
                return;
            }
            catch (Exception vynimka)
            {
                Console.WriteLine(vynimka.Message);
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Zadaj druhé číslo:");
            vstup = Console.ReadLine();
            int cislo2 = int.Parse(vstup);

            Console.WriteLine($"Výsledok delenia je {cislo1 / cislo2}.");

            // int cislo1 = Int32.Parse(Console.ReadLine());
        }

        private static void PracaSCasom()
        {
            Rytier elise = new Rytier("Elise", 3);

            elise.VypisMenoaZivoty();
            // elise.datumNarodenia = DateTime.Now; //okamžitý čas v PC
            elise.datumNarodenia = new DateTime(1999, 1, 6);
            elise.datumNarodenia = elise.datumNarodenia.AddHours(12).AddDays(3).AddMinutes(-39);  // pridávam hodiny, dni a minúty priamo do DateTime

            // Console.WriteLine($"Narodila som sa {elise.datumNarodenia}.");
            Console.WriteLine($"Narodila som sa {elise.datumNarodenia.Day}.{elise.datumNarodenia.Month}.{elise.datumNarodenia.Year}.");

            TimeSpan vek = DateTime.Now - elise.datumNarodenia;

            DateTime novyCas = new DateTime(1980, 6, 1, 18, 20, 0);
            TimeSpan odcitanieHodinAMinut = novyCas - elise.datumNarodenia;

            Console.WriteLine($"Môj vek je {odcitanieHodinAMinut.Days / 365}");

            Console.WriteLine($"Môj vek je {vek.Days / 365}.");
        }
    }
}
