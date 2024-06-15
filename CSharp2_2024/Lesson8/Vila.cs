using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class Vila : RozpravkovaBytost, ITancujucaBytost, IKuzelnaBytost
    {
        public void BudNeviditelny()
        {
            Console.WriteLine("Víla je neviditelna.");
        }

        public void BudViditelny()
        {
            Console.WriteLine("Víla je viditelna.");
        }

        public override void PredstavSa()
        {
            Console.WriteLine("Ja som víla");
        }

        public void PrestanTancovat()
        {
            Console.WriteLine("Víla netancuje.");
        }

        public void ZacniTancovat()
        {
            Console.WriteLine("Víla tancuje.");
        }
    }
}
