using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    interface ITancujucaBytost
    {
        // oproti abstraktnej triede nie su klucove slova abstract, modifikatory pristupu, override, atd
        void ZacniTancovat();
        void PrestanTancovat();

    }
}
