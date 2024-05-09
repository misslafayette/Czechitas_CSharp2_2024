using System.Reflection.Metadata.Ecma335;

namespace Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // VykladZoznamy();

            // Slovnik - DICTIONARY<key, value>

            Dictionary<string, string> slovnikAj = new Dictionary<string, string>
            {
                { "ahoj", "hello"},
                { "auto", "car"},
                { "dom", "house"},
            };

            slovnikAj.Add("kvetina", "flower");

            Console.WriteLine($"kvetina je anglicky {slovnikAj["kvetina"]}.");

            Console.WriteLine();

            foreach (KeyValuePair<string, string> zaznam in slovnikAj)
            { 
                Console.WriteLine($"{zaznam.Key} : {zaznam.Value}");
            }

            foreach (var zaznam in slovnikAj) // var sa snaží uhádnuť datový typ sám
            {
                Console.WriteLine($"{zaznam.Key} : {zaznam.Value}");
            }

            var nazdar = "Nazdárek";
            var desatinnecislo = 0.5;
            Console.WriteLine(nazdar);
            Console.WriteLine(desatinnecislo);

            if (!slovnikAj.ContainsKey("auto"))  // ContainsValue - vracia bool
            {
                slovnikAj.Add("auto", "car");
            }
            else
            {
                Console.WriteLine("Záznam už tam je.");
            }
            Console.WriteLine();

            // TryGetValue

            string anglickyPreklad;
            if (slovnikAj.TryGetValue("mobil", out anglickyPreklad))
            {
                Console.WriteLine($"Preklad ahoj je anglicky {anglickyPreklad}.");
            }
            else
            {
                Console.WriteLine("Také slovíčko tam nie je.");
            }

            slovnikAj.Remove("ahoj");

            slovnikAj["auto"] = "vehicle"; // vymení value v kľúči auto
            slovnikAj["bábika"] = "doll";   // pridám entry

            slovnikAj.Clear();

        }

        private static void VykladZoznamy()
        {
            Rytier elise = new Rytier("Elise", 2);
            Rytier violette = new Rytier("Violette", 1);
            Rytier constantine = new Rytier("Constantine", 3);

            Rytier[] poleRytierov = new Rytier[3] { elise, violette, constantine };

            for (int i = 0; i < poleRytierov.Length; i++)
            {
                poleRytierov[i].VypisMenoAZivoty();
            }

            Rytier astor = new Rytier("Astor", 1);

            // poleRytierov[3] = astor;
            // poleRytierov[3].VypisMenoAZivoty(); // vynimka, takto sa objekt nedá pridať

            // KOLEKCE (List)
            List<Rytier> zoznamRytierov = new List<Rytier>() { elise, violette, constantine };

            zoznamRytierov.Add(astor); // pridá položku   // zoznamRytierov.AddRange(poleRytierov) <- môžem pridať celý rozsah


            for (int i = 0; i < zoznamRytierov.Count; i++) // u listu používame Count namiesto Length
            {
                poleRytierov[i].VypisMenoAZivoty();
            }


            Console.WriteLine();

            foreach (Rytier r in zoznamRytierov)  // elegantnejší zápis pre priechod zoznamom
            {
                r.VypisMenoAZivoty();
            }

            Rytier florent = new Rytier("Florent", 1);

            zoznamRytierov.Insert(0, florent);  // vloženie na konkrétny index v zozname

            Console.WriteLine();

            foreach (Rytier r in zoznamRytierov)
            {
                r.VypisMenoAZivoty();
            }

            zoznamRytierov.Remove(florent);  // remove zmaže danú položku

            int poziciaRytieraa = zoznamRytierov.IndexOf(constantine);   // môžem sa opýtať na index kde to leží
            Console.WriteLine($"Rytier Constantine je na pozici {poziciaRytieraa}.");

            bool jeVZozname = zoznamRytierov.Contains(elise);  // otázka či tam daná položka je
            if (jeVZozname)
            {
                Console.WriteLine("Je tam.");
            }
            else
            {
                Console.WriteLine("Nie je tam.");
            }

            Console.WriteLine();

            string menoNaZmazanie = "Constantine";
            Rytier najdenyRytier = zoznamRytierov.Find(r => r.Meno == menoNaZmazanie);

            zoznamRytierov.Remove(najdenyRytier);

            foreach (Rytier r in zoznamRytierov)
            {
                r.VypisMenoAZivoty();
            }

            // Sort

            Console.WriteLine();

            zoznamRytierov.Sort(PorovnajRytierov);

            foreach (Rytier r in zoznamRytierov)
            {
                r.VypisMenoAZivoty();
            }

            zoznamRytierov.Clear(); // zmažem celý zoznam
        }

        private static int PorovnajRytierov(Rytier prvy, Rytier druhy)
        {
            return string.Compare(prvy.Meno, druhy.Meno, true);
        }
    }
}