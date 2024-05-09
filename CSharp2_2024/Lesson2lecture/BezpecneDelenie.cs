using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2lecture
{
    public class BezpecneDelenie
    {
        public double PodelCisla(double a, double b)
        {
            // keď mi užvateľ dá b = 0, tak si s tým neviem poradiť
            // chcem, aby to skončilo chybou

            if (b == 0.0)
            {
                throw new ArgumentException("Nulou nejde deliť.");
            }
            return a / b;

        }
    }
}
