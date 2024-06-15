namespace Lesson7_Breakoutroom1
{

    //navrhnete vhodnou strukturu trid, ktera umozni v programu (v Mainu) vytvorit seznam zviratek v zoo koutku (List), 
    //ktery pak muzeme jednoduse projit cyklem (foreach) a zadat kazdemu z nich prikaz VydavejZvuk
    //pritom kazde zviratko bude vydavat jiny zvuk (vypise na konzoli Haf, haf nebo Mnau, mnau)
    //v ramci cyklu nechci resit, jake konkretni zviratko to je
    //vytvorte alespon 3 ruzna zviratka
    //hint: budete potrebovat vhodnou bazovou tridu a virtual/abstract a override

    public abstract class Zviera
    {
        public abstract void VydavajZvuk();
    }

    public class Pes : Zviera
    {
        public override void VydavajZvuk()
        {
            Console.WriteLine("Haf haf.");
        }
    }
    public class Macka : Zviera
    {
        public override void VydavajZvuk()
        {
            Console.WriteLine("Mnau mnau.");
        }
    }

    public class Krava : Zviera
    {
        public override void VydavajZvuk()
        {
            Console.WriteLine("Muu muu.");
        }
    }

    public class Ovca : Zviera
    {
        public override void VydavajZvuk()
        {
            Console.WriteLine("Bee bee.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Pes pes = new Pes();
            Macka macka = new Macka();
            Krava krava = new Krava();
            Ovca ovca = new Ovca();

            List<Zviera> zoo = new List<Zviera>();
            zoo.Add(pes);
            zoo.Add(macka);
            zoo.Add(krava);
            zoo.Add(ovca);

            foreach (var x in zoo)
            {
                x.VydavajZvuk();
            }

        }
    }
}
