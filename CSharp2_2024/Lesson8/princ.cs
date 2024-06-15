using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class Princ : RozpravkovaBytost, ITancujucaBytost
    {
        public override void PredstavSa()
        {
            Console.WriteLine("Ja som princ.");
        }

        public void PrestanTancovat()
        {
            Console.WriteLine("Princ prestal tancovat.");
        }

        public void ZacniTancovat()
        {
            Console.WriteLine("Princ zacal tancovat.");
        }
    }
}
