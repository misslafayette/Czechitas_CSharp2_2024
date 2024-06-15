using System.Runtime.CompilerServices;

namespace Lesson5_BreakoutRoom1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Nalezněte slova začínající písmenem 'M'
            List<string> ovoce = new List<string>() { "Merunka", "Jablko", "Pomeranc", "Meloun", "Malina", "Limetka" };
            List<string> mOvoce = null;

            mOvoce = ovoce.Where(r => r.StartsWith("M")).ToList();

            foreach (string o in mOvoce)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine();

            // 2. Která z následujících čísel jsou násobky 4 nebo 6
            List<int> ruznaCisla = new List<int>()
                {
                    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
                };

            List<int> nasobky4a6 = null;

            nasobky4a6 = ruznaCisla.Where(r => r % 4 == 0 || r % 6 == 0).ToList();
 

            foreach (int cislo in nasobky4a6)
                {
                    Console.WriteLine(cislo);
                }

            Console.WriteLine();

            // 3. Kolik je v seznamu ruznaCisla čísel?
            Console.WriteLine("?????");
            Console.WriteLine();

            // 5. Kolik je celkový součet?

            List<double> utrata = new List<double>()
            {
                 2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };

            Console.WriteLine("?????");
            Console.WriteLine();

            // 6. Jaké je největší cena?

            List<double> cena = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };

            Console.WriteLine($"Najväčšia cena je: {cena.Max()}");

        }
    }
}
