namespace Lesson7
{

    public abstract class BaseTrieda
    {
        public int id { get; set; } = 0;
    }

    public abstract class RozpravkovaBytost : BaseTrieda
    {
        public string Meno { get; set; }

        public virtual void AkoSaVolam()
        {
            Console.WriteLine(Meno);
        }

        public abstract void Zautocim();
    }

    public class Hrdina : RozpravkovaBytost
    {
        public int Zivoty { get; set; } = 10;

        public override void Zautocim()
        {
            {
                Console.WriteLine(Meno + " svihol mecom.");
            }
        }
    }

    public class Superhrdina: Hrdina
    {
        public void PouziSuperSchopnost ()
        {
            Console.WriteLine(Meno + " pouzije laserove oci.");
        }
    }

    public class Carodejnica: RozpravkovaBytost
    {
        public override void Zautocim()
        {
            {
                Console.WriteLine(Meno + " vykuzlila ohnivu gulu.");
            }
        }

        public override void AkoSaVolam()
        {
            base.AkoSaVolam();
            Console.WriteLine("Volám sa " + Meno + ".");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Hrdina Adam = new Hrdina();
            Adam.Meno = "Adam";
            Adam.AkoSaVolam();
            Adam.Zivoty = 11;

            /* RozpravkovaBytost vila = new RozpravkovaBytost();
            vila.Meno = "Konvalinka"; */

            Carodejnica bielaPani = new Carodejnica() { Meno = "Biela Pani" };
           
            List<RozpravkovaBytost> rozpravkoveBytosti = new List<RozpravkovaBytost>();
            rozpravkoveBytosti.Add(Adam);
            rozpravkoveBytosti.Add(bielaPani);

            rozpravkoveBytosti.ForEach(x => x.AkoSaVolam());
            rozpravkoveBytosti.ForEach(x => x.Zautocim());
            foreach (var bytost in rozpravkoveBytosti)
            {
                bytost.AkoSaVolam();

            }

            int pocitadlo = 0;
            foreach (var bytost in rozpravkoveBytosti)
            {
                if (bytost is Superhrdina)
                {
                    Console.WriteLine($"Ja som superhrdina {bytost.Meno}.");
                    pocitadlo++;
                    Superhrdina druhySuperman = (Superhrdina)bytost;
                    druhySuperman.PouziSuperSchopnost();
                    Console.WriteLine(druhySuperman.ToString());
                }

                object temp = bytost;
                Console.WriteLine(temp.ToString());
            }
            Console.WriteLine($"Máme {pocitadlo} superhrdinov.");
        }
    }
}
