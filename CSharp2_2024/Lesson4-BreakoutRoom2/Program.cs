namespace Lesson4_BreakoutRoom2
{
    internal class Program
    {

        /* Vytvorte tridu TelefonniSeznam
        - uvnitr ni budete ukladat dvojice Jmeno - Telefonni cislo
        - k tomu pouzijte Dictionary, jehoz klice budou stringy a hodnoty integery
        - v ramci konstruktoru vyplnte nekolik jmen a cisel
        - vytvorte metodu, ktera do slovniku ulozi noveho cloveka a jeho telefonni cislo
        - vytvorte metodu, ktera vrati telefonni cislo cloveka
        - vytvorte metodu, ktera vypise cely telefonni seznam
        - vytvorte metodu, ktera smaze daneho cloveka
        - vytvorte metodu, ktera smaze cely telefonni seznam .Clear()
        - myslete na mozne chybove stavy (co kdyz tam dany clovek neni, co kdyz pridavam cloveka, ktery uz tam je)
        - napiste kratky program, ktery overi funkcnost teto tridy */

        static void Main(string[] args)
        {
            var telefonniSeznam = new TelefonniSeznam();

            // - vytvorte metodu, ktera vypise cely telefonni seznam
            telefonniSeznam.VypisVse();
            Console.WriteLine();

            // - vytvorte metodu, ktera do slovniku ulozi noveho cloveka a jeho telefonni cislo
            telefonniSeznam.Pridat("Matýsek", 796154238);
            telefonniSeznam.Pridat("Pepa", 123456789);
            Console.WriteLine();

            telefonniSeznam.VypisVse();
            Console.WriteLine();

            // - vytvorte metodu, ktera vrati telefonni cislo cloveka
            telefonniSeznam.VypisCislo("Albert");
            telefonniSeznam.VypisCislo("Matýsek");
            telefonniSeznam.VypisCislo("NěkdoNeznámý");
            Console.WriteLine();

            // - vytvorte metodu, ktera smaze daneho cloveka
            telefonniSeznam.Smazat("Matýsek");
            telefonniSeznam.Smazat("NěkdoNeznámý");
            Console.WriteLine();

            telefonniSeznam.VypisVse();
            Console.WriteLine();

            // - vytvorte metodu, ktera smaze cely telefonni seznam.Clear()
            telefonniSeznam.SmazatVse();

            telefonniSeznam.VypisVse();
            Console.WriteLine();
        }
    }
}
