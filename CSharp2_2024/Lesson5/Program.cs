namespace Lesson5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rytier elise = new Rytier("Elise", 100, "OR");
            Rytier violette = new Rytier("Violette", 100, "OR");
            Rytier constantine = new Rytier("Constantine", 80, "OR");
            Rytier astor = new Rytier("Constantine", 50, "OR");
            Rytier sandrine = new Rytier("Sandrine", 10, "OR");

            List<Rytier> rytieri = new List<Rytier>() { elise, violette, constantine, astor, sandrine };

            var silniRytieri = rytieri.Where(r => r.Zdravie > 90); // lambda (skrátený zápis za plnohodnotnú funkciu); r = vstup je naľavo od šípky ;; výstup je napravo od šípky
            var silniRytieri2 = rytieri.Where(JeSilny);

            // predikát je exaktní termín z informatiky a označuje to jakoukoliv funkci, která vrací bool (a nikdy nic jiného).
            // A vždy berie len jeden parameter

            foreach (Rytier rytier in silniRytieri)
            {
                Console.WriteLine(rytier.Meno);
            }

            // Console.WriteLine($"Počet slabých rytierov je {rytieri.Count(r => r.Zdravie > 25)}.");

            var slabiRytieri = rytieri.Where(r => r.Zdravie < 100);
            Console.WriteLine($"Počet slabých rytierov je {slabiRytieri.Count()}.");  // Count nie je LINQ

            var neexistujuciRytieri = rytieri.Where(r => r.Zdravie > 200);

            Rytier prvyNeexistujuciRytier = neexistujuciRytieri.FirstOrDefault();
            if (prvyNeexistujuciRytier is not null)
            {

                Console.WriteLine($"Neexistujúci rytier je: {prvyNeexistujuciRytier.Meno}.");
            }
            else
            {
                Console.WriteLine("Rytier naozaj neexistuje.");
            }

            // neexistujuciRytieri.FirstOrDefault();

            Console.WriteLine($"Prvý rytier je {rytieri.First().Meno}.");
            Console.WriteLine($"Posledný rytier je {rytieri.Last().Meno}");

            Console.WriteLine($"Priemerné zdravie rytiera je {rytieri.Average(r => r.Zdravie)}");
            Console.WriteLine($"Priemerné zdravie slabého rytiera je {slabiRytieri.Average(r => r.Zdravie)}");

            Console.WriteLine($"Existuje rytier silnejší než 100: {rytieri.Any(r => r.Zdravie > 100)}");
            Console.WriteLine($"Sä všetci rytieri silnejší než 5: {rytieri.All(r => r.Zdravie > 5)}");

            var rytieriPodlaMena = rytieri.OrderBy(r =>r.Meno); // zoraďovanie

            var rytieriPodlaNarodnosti = rytieri.GroupBy(r => r.Krajina); // vytvorím zoskupenie
            foreach (var skupinaRytierov in rytieriPodlaNarodnosti)   
            {
                Console.WriteLine(skupinaRytierov.Key);
                foreach (Rytier rytier in skupinaRytierov)
                {
                    Console.WriteLine(rytier.Meno);
                }
            }
        }


        private static bool JeSilny(Rytier rytier)
        {
            return rytier.Zdravie > 90;
        }

        class Rytier
        {
            public string Meno;
            public int Zdravie;
            public string Krajina;

            public Rytier(string meno, int pocetZivotov, string krajina)
            {
                Meno = meno;
                Zdravie = pocetZivotov;
                Krajina = krajina;
            }
        }
    }
}
