using System.ComponentModel;

namespace Lesson9_Breakoutroom1
{

    public class Clovek
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int TelCislo { get; set; }

        public Clovek(string jmeno, string prijmeni, int telCislo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            TelCislo = telCislo;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Clovek> telefonnyZoznam = new List<Clovek>
        {
            new Clovek("Jarda", "Kadlec", 777123456),
            new Clovek("Honza", "Kratochvila", 777987654),
            new Clovek("Petr", "Novak", 778111222)
        };

            // 1. Vytvorte slozku TelefonniSeznam v adresari Appdata pro konkretniho uzivatele

            var adresar = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TelefonnyZoznam");
            if (!Directory.Exists(adresar))
            {
                Directory.CreateDirectory(adresar);
            }

            // 2. Do souboru telefonniSeznam.csv ulozte obsah seznamu telefonniSeznam tak,
            //   ze kazdy zaznam bude na jednom radku a oddelene budou carkami

            string subor = Path.Combine(adresar, "telefonnyZoznam.csv");
            File.WriteAllText(subor, "Meno; Priezvisko; TelCislo" + Environment.NewLine);

            var riadky = telefonnyZoznam.Select(clovek => $"{clovek.Jmeno}; {clovek.Prijmeni}; {clovek.TelCislo}");
            File.AppendAllLines(subor, riadky);

            // 3. Napiste cyklus, ktery soubor precte a zpatky ho ulozi do noveho seznamu

            if (File.Exists(subor))
            {
                var nacitaneZoSuboru = File.ReadAllLines(subor);
                foreach (var riadok in nacitaneZoSuboru)
                {
                    Console.WriteLine(riadok);
                }
            }
            else
            {
                Console.WriteLine("Súbor nenájdený.");
            }

        }
    }
}
