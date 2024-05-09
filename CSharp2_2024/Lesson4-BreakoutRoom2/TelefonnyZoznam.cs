using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_BreakoutRoom2
{

    // Vytvorte tridu TelefonniSeznam
    public class TelefonniSeznam
    {
        // - uvnitr ni budete ukladat dvojice Jmeno - Telefonni cislo
        // - k tomu pouzijte Dictionary, jehoz klice budou stringy a hodnoty integery
        public Dictionary<string, int> Seznam;

        public TelefonniSeznam()
        {
            // - v ramci konstruktoru vyplnte nekolik jmen a cisel
            Seznam.Add("Albert", 777152156);
            Seznam.Add("Pepa", 603390878);
            Seznam.Add("Michal", 721556843);
        }

        // - vytvorte metodu, ktera do slovniku ulozi noveho cloveka a jeho telefonni cislo
        public void Pridat(string jmeno, int cislo)
        {
            if (Seznam.ContainsKey(jmeno))
            {
                Console.WriteLine($"V seznamu už existuje záznam se jménem {jmeno}.");
                return;
            }

            try
            {
                Seznam.Add(jmeno, cislo);
                Console.WriteLine($"{jmeno} vložen úspěšně.");
            }
            catch
            {
                Console.WriteLine($"Nepodařilo se vložit záznam {jmeno} s telefonním číslem {cislo}.");
            }
        }

        // - vytvorte metodu, ktera vrati telefonni cislo cloveka
        public int? VypisCislo(string jmeno)
        {
            if (Seznam.TryGetValue(jmeno, out int cislo))
            {
                Console.WriteLine($"{jmeno}: {cislo}");
                return cislo;
            }

            Console.WriteLine($"V seznamu neexistuje záznam se jménem {jmeno}.");
            return null;
        }

        // - vytvorte metodu, ktera vypise cely telefonni seznam
        public void VypisVse()
        {
            Console.WriteLine("Telefonní seznam:");

            foreach (var zaznam in Seznam)
            {
                Console.WriteLine($"{zaznam.Key}: {zaznam.Value}");
            }
        }

        // - vytvorte metodu, ktera smaze daneho cloveka
        public void Smazat(string jmeno)
        {
            if (!Seznam.ContainsKey(jmeno))
            {
                Console.WriteLine($"V seznamu neexistuje záznam se jménem {jmeno}.");
                return;
            }

            try
            {
                Seznam.Remove(jmeno);
                Console.WriteLine($"{jmeno} odstraněn úspěšně.");
            }
            catch
            {
                Console.WriteLine($"Nepodařilo se odstranit záznam {jmeno}.");
            }
        }

        // - vytvorte metodu, ktera smaze cely telefonni seznam.Clear()
        public void SmazatVse()
        {
            Seznam.Clear();
        }
    }
}
