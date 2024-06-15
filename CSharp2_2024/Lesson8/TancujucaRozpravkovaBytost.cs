using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    abstract class TancujucaRozpravkovaBytost : RozpravkovaBytost
    {
        public abstract void ZacniTancovat();
        public abstract void PrestanTancovat();
    }
}
