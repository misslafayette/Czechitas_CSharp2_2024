﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;

namespace L4B2
{

    // Vytvorte tridu TelefonniSeznam
    // uvnitr ni budete ukladat dvojice Jmeno - Telefonni cislo
    // k tomu pouzijte Dictionary, jehoz klice budou stringy a hodnoty integery
    //- v ramci konstruktoru vyplnte nekolik jmen a cisel
    //- vytvorte metodu, ktera do slovniku ulozi noveho cloveka a jeho telefonni cislo
    //- vytvorte metodu, ktera vrati telefonni cislo cloveka
    //- vytvorte metodu, ktera vypise cely telefonni seznam
    //- vytvorte metodu, ktera smaze daneho cloveka
    //- vytvorte metodu, ktera smaze cely telefonni seznam.Clear()
    //- myslete na mozne chybove stavy(co kdyz tam dany clovek neni, co kdyz pridavam cloveka, ktery uz tam je)
    //- napiste kratky program, ktery overi funkcnost teto tridy

    public class TelefonnyZoznam
    {

        public Dictionary<string, int> Zoznam { get; set; }



        internal class Program
        {
            static void Main(string[] args)
            {


            }
        }
    }
}
