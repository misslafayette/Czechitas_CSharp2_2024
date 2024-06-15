namespace Lesson8_Breakoutroom2
{
    public abstract class Tvar : IViePocitatObsah, IViePocitatObvod
    {
        public double SpocitajObsah()
        {
            throw new NotImplementedException();
        }

        public double SpocitajObvod()
        {
            throw new NotImplementedException();
        }
    }

    public class Obdlznik: Tvar
    {
        private readonly double Sirka;
        private readonly double Dlzka;

        public Obdlznik(double sirka, double dlzka)
        {
            Sirka = sirka;
            Dlzka = dlzka;
        }

        public double SpocitajObsah()
        {
            return Sirka * Dlzka;
        }

        public double SpocitajObvod()
        {
            return 2* (Sirka + Dlzka);
        }
    }

    public class Kruh : Tvar
    {
        private readonly double Polomer = 4;
        public Kruh(double polomer)
        {
            Polomer = polomer;
        }

        public double SpocitajObsah()
        {
            return Math.PI*Math.Pow(Polomer, 2);
        }

        public double SpocitajObvod()
        {
            return 2 * Math.PI * Polomer;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //napiste dva ruzne interfacy: IUmiPocitatObsah, IUmiPocitatObvod
            //implementujte tridy obdelnik a kruh, ktere oba interfacy pouzivaji
            //vlozte jejich instance do seznamu a zavolejte na nich prislusne metody na vypocet obsahu a obvodu

            Tvar obdlznik = new Obdlznik(2, 4);
            Tvar kruh = new Kruh(4);

            List<Tvar> tvary = new List<Tvar> { obdlznik, kruh };

            foreach (Tvar tvar in tvary)
            {
                Console.WriteLine(tvar.SpocitajObsah());
                Console.WriteLine(tvar.SpocitajObvod());
            }
        }
    }
}
