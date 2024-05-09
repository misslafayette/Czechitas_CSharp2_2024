namespace Lesson4_BreakoutRoom1
{
    internal class Program
    {
        private static void Vypis(List<double> cisla)
        {
            Console.WriteLine("Čísla v zozname:");

            foreach (double c in cisla) ;
        }

        private static void VypisPocet(List<double> cisla)
        {
            Console.WriteLine($"Počet čísel v zozname: {cisla}");

            foreach (double c in cisla) ;
        }

        static void Main(string[] args)
        {
            List<double> cisla = new List<double>
            {
            0.046939913,
            0.295866297,
            0.852489925,
            0.84994766,
            0.96925183,
            0.946275497,
            0.688903175,
            0.553463564,
            0.59628254,
            0.645816929
            };


            // Vypis vsechna cisla na konzoli (nachystej si pro to funkci)
            Vypis(cisla);

            // Vypis na konzoli pocet cisel v seznamu
            VypisPocet(cisla);


            // Pridej cislo 0.5 do seznamu

            Console.WriteLine($"Do zoznamu je pridané číslo 0.5.");
            cisla.Add(0.5);
            // cisla.Insert(cisla.Count, 0.5); --> does the same thing as the line above

            // vypis prvni cislo ze seznamu, ktere je vetsi nez 0.8
            foreach (double x in cisla)
            {
                if (x > 0.8)
                {
                    Console.WriteLine($"Prvé číslo väčšie ako 0.8 je {x}.");
                    break;
                }
            }

            // najdi nejvetsi cislo v seznamu, vypis, ktere to je, a odstran ho ze seznamu
            var max = cisla.Max();
            Console.WriteLine($"Najväčšie číslo v zozname je {max}. Číslo je zmazané.");
            cisla.Remove(max);

            // vypis opet vsechna cisla a jejich pocet
            Vypis(cisla);
            VypisPocet(cisla);
        }
    }
}
