using Microsoft.Win32.SafeHandles;
using System.Linq;

namespace Lesson5_BreakoutRoom2
{
    internal class Program
    {

        public class Banka
        {
            public string Symbol { get; set; }
            public string Jmeno { get; set; }
        }

        public class Zakaznik
        {
            public string Jmeno { get; set; }
            public double Zustatek { get; set; }
            public string Banka { get; set; }
        }

        public class SkupinaMilionaru
        {
            public string Banka { get; set; }
            public IEnumerable<string> Milionari { get; set; }
        }

        static void Main(string[] args)
        {

            // 4. Seřaďte jména vzestupně
            List<string> jmena = new List<string>()
            {
                "Hana", "Jaroslav", "Xenie", "Michaela", "Borivoj", "Nela",
                "Katerina", "Sofie", "Adam", "David", "Zuzana", "Barbara",
                "Tereza", "Lenka", "Svetlana", "Cecilie", "Renata",
                "Evzen", "Pavel", "Eliska", "Viktor", "Antonin",
                "Frantisek", "Radek"
            };

            List<string> vzestupne = null;

            vzestupne = jmena.OrderByDescending(r => r).ToList();

            foreach (string text in vzestupne)
            {
                Console.WriteLine(text);
            }


            // 7. Zobrazte vsechny milionare v kazde bance
            // Napr. 
            // CS: Jan Novak a Josef Novotny
            // KB: Jana Nova

            List<Zakaznik> zakaznici = new List<Zakaznik>() { 
            new Zakaznik() { Jmeno = "Jan Maly", Zustatek = 10345.50, Banka = "CS" },
            new Zakaznik(){ Jmeno="Jiri Hladny", Zustatek=452.10, Banka="KB"},
            new Zakaznik(){ Jmeno="Lenka Sporiva", Zustatek=523665.13, Banka="CS"},
            new Zakaznik(){ Jmeno="Marie Bohata", Zustatek=7482184.38, Banka="FIO"},
            new Zakaznik(){ Jmeno="Michal Marny", Zustatek=745234.93, Banka="KB"},
            new Zakaznik(){ Jmeno="Lada Vychytraly", Zustatek=8832937.34, Banka="CS"},
            new Zakaznik(){ Jmeno="Sandra Nedostatecna", Zustatek=942488.48, Banka="KB"},
            new Zakaznik(){ Jmeno="Silvie Zavodou", Zustatek=56198334.72, Banka="FIO"},
            new Zakaznik(){ Jmeno="Tereza Presna", Zustatek=1000000.00, Banka="CITI"},
            new Zakaznik(){ Jmeno="Stefan Pilny", Zustatek=48282.73, Banka="CITI"}
            };

            List<SkupinaMilionaru> skupinyPodleBanky = null;
            var skupinaMilionarov = zakaznici.Any(r => r.Zustatek > 1000000);

            var zakazniciPodlaBanky = zakaznici.GroupBy(r => r.Banka);
            foreach (var s in zakazniciPodlaBanky)
            {
                Console.WriteLine();
                    foreach (Zakaznik zakaznik in zakaznici)
                {
                    Console.WriteLine(zakaznik.Jmeno);
                }
            }

            foreach (var polozka in skupinyPodleBanky)
            {
                Console.WriteLine(polozka.Banka + ": " + string.Join(" a ", polozka.Milionari));
            }

            /*
            
            // 8. Vytisknete jmeno kazdeho milionare a jeho banky
            // Napr
            // Jan Novak v Ceska Sporitelna
            // Josef Novotny v Komercni Banka
            List<Banka> banky = new List<Banka>() {
            new Banka(){ Jmeno="Ceska Sporitelna", Symbol="CS"},
            new Banka(){ Jmeno="Komercni Banka", Symbol="KB"},
            new Banka(){ Jmeno="Fio Banka", Symbol="FIO"},
            new Banka(){ Jmeno="Citibank", Symbol="CITI"},
            };

            */
        }
    }
}
