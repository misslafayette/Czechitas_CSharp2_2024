using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    internal class Rytier
    {
        public string Meno;
        public int PocetZivotov;

        public Rytier(string meno, int pocetZivotov)
        {
            Meno = meno;
            PocetZivotov = pocetZivotov;
        }

        public void VypisMenoAZivoty()
        { 
            Console.WriteLine($"Volám sa {Meno} a mám {PocetZivotov} životov.");
        }
    }
}
