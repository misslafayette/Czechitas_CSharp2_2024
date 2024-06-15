using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class Carodej : RozpravkovaBytost, IKuzelnaBytost
    {

        public void BudNeviditelny()
        {
            Console.WriteLine("Carodej je neviditelny.");
        }

        public void BudViditelny()
        {
            Console.WriteLine("Carodej je viditelny.");
        }

        public override void PredstavSa()
        {
            Console.WriteLine("Ja som carodej.");
        }
    }
}
