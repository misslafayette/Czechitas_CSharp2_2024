using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2lecture
{

    // trieda Rytier - 2 vlastnosti a metóda
    // meno a počet životov
    // met=oda VypisMenoAZivoty

    internal class Rytier
    {
        public string Meno { get; set; }
        public int Zivoty { get; set; }

        public DateTime datumNarodenia;

        public Rytier(string meno, int zivoty)
        {
            Meno = meno;
            Zivoty = zivoty;
        }

        public void VypisMenoaZivoty()
        {
            Console.WriteLine($"Volám sa {Meno} a mám {Zivoty} životov.");
        }
    }
}
