namespace Lesson8_Breakoutroom1
{
    abstract class RozpravkovaBytost
    {
        public abstract void NapisAkoTravisVolnyCas();
    }

    class Princezna : RozpravkovaBytost 
    {
        public override void NapisAkoTravisVolnyCas()
        {
            Console.WriteLine("Vo volnom case spievam.");
        }
    }

    class Rytier : RozpravkovaBytost
    {
        public override void NapisAkoTravisVolnyCas()
        {
            Console.WriteLine("Vo volnom case jazdim na koni.");
        }
    }

    class Carodejnica : RozpravkovaBytost
    {
        public override void NapisAkoTravisVolnyCas()
        {
            Console.WriteLine("Vo volnom case citam.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Vytvořte abstraktní třídu PohadkovaBytost a v ní abstraktní metodu NapisJakTravisVolnyCas
            // Vytvorte tridy Princezna, Rytir, Carodenice, ktere dedi PohadkovouBytost
            // Naimplementujte metodu NapisJakTravisVolnyCas - vypsanemu textu na konzoli se meze nekladou
            // Vytvorte instance od kazde tridy a vypiste informace o trávení volného času.

            RozpravkovaBytost princezna = new Princezna();
            RozpravkovaBytost rytier = new Rytier();
            RozpravkovaBytost carodejnica = new Carodejnica();


            List<RozpravkovaBytost> bytosti = new List<RozpravkovaBytost> { princezna, rytier, carodejnica};
            foreach (var bytost in bytosti)
            {
                bytost.NapisAkoTravisVolnyCas();
            }

        }
    }
}
