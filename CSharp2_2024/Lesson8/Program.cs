namespace Lesson8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // princ, princezna, carodej
            // Rozprávkové bytosti - bázová trieda

            /*
            Princezna lynette = new Princezna();
            Princ avery = new Princ();  
            Carodej michel = new Carodej();
            */

            RozpravkovaBytost lynette = new Princezna();
            RozpravkovaBytost avery = new Princ();
            RozpravkovaBytost michel = new Carodej();
            RozpravkovaBytost amalka = new Vila();

            List<RozpravkovaBytost> bytosti = new List<RozpravkovaBytost> { lynette, avery, michel, amalka };

            foreach (var bytost in bytosti)
            {
                bytost.PredstavSa();
            }

            // tancujuca rozpravkova bytost
            /*
            // vydavam prikaz k pociatku a koncu tancovania

            foreach (TancujucaRozpravkovaBytost tpb in bytosti)
            {
                tpb.ZacniTancovat();
                tpb.PrestanTancovat();
            }
            */

            foreach (ITancujucaBytost tpb in bytosti.OfType<ITancujucaBytost>())
            {
                tpb.ZacniTancovat();
                tpb.PrestanTancovat();
            }

            // michel.BudNeviditelny(); -> nejde to, treba to pretypovat
            // prva varianta pretypovania:
            ((Carodej)michel).BudNeviditelny();
            ((Carodej)michel).BudViditelny();

            // druha variant pretypovania:
            (michel as Carodej).BudNeviditelny();
            (michel as Carodej).BudViditelny();


            // dá sa otestovať priamo v podmienke
            if (michel is Carodej)
            {
                ((Carodej)michel).BudNeviditelny();
            }

            // 2. varianta otestovania s deklaraciou v premennej
            if (michel is Carodej carodej)
            {
                carodej.BudNeviditelny();
            }

            // 3. varianta
            (michel as Carodej)?.BudViditelny() ;

            // mozne v .NET8
            // michel?.BudNeviditelny();

            // dá sa zúžiť chovanie danéhoi objektu len na daný interface
            ITancujucaBytost princezna2 = new Princezna();
            

            Console.ReadLine();
        }
    }
}
