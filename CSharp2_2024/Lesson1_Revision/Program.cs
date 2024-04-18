namespace Lesson1_Revision
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Zbyvajici dny do dovolene
            // Postupne se uzivatele ptej na den, mesic a rok odjezdu na dovolenou. Pomoci DateTime a TimeSpan vypocitej poct
            // zbyvajicich dni do odjezdu na dovolenou a vypis je na konzoli
            // Pozn.: pro zjednoduseni staci pouzit int.Parse

            Console.WriteLine("Zadaj den odjazdu:");
            int leavingDay = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadaj mesiac odjazdu:");
            int leavingMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadaj rok odjazdu:");
            int leavingYear = int.Parse(Console.ReadLine());

            DateTime vacationStart = new DateTime(leavingYear, leavingMonth, leavingDay);

            TimeSpan timeToVacation = vacationStart - DateTime.Now;

            if (timeToVacation < TimeSpan.Zero)
            {
                Console.WriteLine("Už je po dovolenke.");
            }
            else if (timeToVacation < TimeSpan.FromDays(1))
            {
                Console.WriteLine("Nevysedávaj pri počítači a bež baliť kufre, o chvíľu odchádzaš!");
            }
            else
            {
                Console.WriteLine($"Do odchodu na dovolenku ostava: {timeToVacation.Days} dní.");
            }
        }
    }
}
