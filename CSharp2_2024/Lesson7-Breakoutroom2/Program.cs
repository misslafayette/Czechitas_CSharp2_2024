namespace Lesson7_Breakoutroom2
{
    public class GrafickyObjekt
    {
        public virtual void Vykreslit()
        {
            Console.WriteLine("X");
        }
    }

    public class Obdelnik : GrafickyObjekt
    {
        public override void Vykreslit()
        {

        }
    }

    public class Trojuhelnik : GrafickyObjekt
    {
        public override void Vykreslit()
        {

        }
    }

    public class Text : GrafickyObjekt
    {
        public override void Vykreslit()
        {

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Vytvořte program, který bude umět vykreslit na konzoli grafické objekty.

            // Vytvoře třídu GrafickyObjekt, který bude mít virtuální metodu Vykreslit bez parametrů.
            // Metoda po zavolání vypíše "X", protože se netýká konkrétního tvaru.

            // Vytvoře třídy Obdelnik, Trojuhelnik a Text, které budou z grafického objektu dědit.

            // Obdelnik vykreslí na konzoli obdélník z #

            // Trojůhelník vykreslí na konzoli trojůhelník z #

            // Text vypíše text, zadaný do vlastnosti Text

            // Vytvořte program, který bude mít seznam grafických objektů. Vložte jednotlivé objekty do seznamu a potom ho v cyklu vykreslete.

            Obdelnik obdlznik = new Obdelnik();
            Trojuhelnik trojuholnik = new Trojuhelnik();
            Text text = new Text();

            List<GrafickyObjekt> objekty = new List<GrafickyObjekt>();

            foreach (var objekt in objekty )
            { 
                
            }

            // Rozšíření:
            // Pro Obdelnik definujte vlastnosti Vyska a Sirka a zkuste nastavit, z kolik symbolů na výšku a šířku se má vykreslit.
            // Pro trojůhelník zkuste podobně kolik má mít pater ve vlastnosti Vyska.

            // Zkuste třídu GrafickyObjekt rozšířit o vlastnost Barva, kterou pak můžete nastavit na konzoli a vykreslit objekty různou barvou.
            // Provede se to následovně:

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("####");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Bila");
        }
    }
}
