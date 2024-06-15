using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    internal class Princezna : RozpravkovaBytost, ITancujucaBytost
    {
        public override void PredstavSa()
        {
            Console.WriteLine("Ja som princezna.");
        }

        public void PrestanTancovat()
        {
            Console.WriteLine("Princezna prestala tancovať.");
        }

        public void ZacniTancovat()
        {
            Console.WriteLine("Princezna zacala tancovat.");
        }
    }
}
