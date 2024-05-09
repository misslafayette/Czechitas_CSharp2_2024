using System.Text;

namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("-------------");
            string oddelovac = new string('-', 13);
            Console.WriteLine(oddelovac);

            char maleAcko = 'a';
            char velkeAcko = char.ToUpper(maleAcko);

            Console.WriteLine(char.IsUpper(maleAcko));
            Console.WriteLine(char.IsUpper(velkeAcko));

            Console.WriteLine($"Malé a vyzerá takto: {maleAcko} a veľké A vyzerá takto: {velkeAcko}.");

            Console.WriteLine(maleAcko - velkeAcko);
            int ciselnaHodnotaMaleAcko = (int)maleAcko;
            int ciselnaHodnotaVelkeAcko = (int)velkeAcko;
            Console.WriteLine(ciselnaHodnotaMaleAcko);
            Console.WriteLine(ciselnaHodnotaVelkeAcko);

            /*
             * for (int i = 0; i <127; i++)
            {
                Console.Write(i);
                Console.Write(" ");
                Console.WriteLine((char)i); // vypíše hodnoty znakov
            }
            */

            int vychoziInt = default(int);
            string vychoziString = default(string);

            Console.WriteLine(vychoziInt == null);
            Console.WriteLine(vychoziString == null);

            string vstup = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(vstup))
            { 
                Console.WriteLine("Zlý vstup, skús to znovu.");
                vstup = Console.ReadLine(); 
            }

            Console.WriteLine($"Malé a vyzerá takto: {maleAcko}.");

            /*
            string username = "Anita";
            string password = "Czechitas";
            Console.WriteLine("Zadaj meno:");
            string vstupUsername = Console.ReadLine();
            string vstupOcisteny = vstupUsername.TrimEnd(' ', '-');
            Console.WriteLine($"Vstup pôvodný: [{vstupUsername}], vstup po očístení: [{vstupOcisteny}].");
            if (string.Equals(username, vstupOcisteny, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Zadaj heslo:");
                string vstupPassword = Console.ReadLine();
                if (vstupPassword == password)
                { 
                    Console.WriteLine($"Vitaj, {username}. Všetko je v poriadku.");
                }
            }
            */

            string prvyString = "ab";
            string druhyString = "ac";
            int vysledokPorovnania = string.Compare(prvyString, druhyString, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine($"Výsledok porovnania: {vysledokPorovnania}.");


            string dlhyText = "Ahoj Pepo, jak se mas? Ahoj.";
            bool obsahujePepu = dlhyText.Contains("Pepo", StringComparison.OrdinalIgnoreCase);
            int indexPepa = dlhyText.IndexOf("Pepo");
            Console.WriteLine($"Obsahuje Pepu: {obsahujePepu} na {indexPepa + 1}. pozícii.");

            string prvych10Znakov = dlhyText.Substring(0, 10);
            Console.WriteLine($"Prvých desať znakov je: {prvych10Znakov}.");
            string odPepy = dlhyText.Substring(startIndex: indexPepa);
            Console.WriteLine($"Znaky od Pepy: {odPepy}.");

            string pozdravHonzy = dlhyText.Replace("Pepo", "Honzo");
            Console.WriteLine($"Pozdrav Honzy: {pozdravHonzy}");

            string pozdravPepyCau = dlhyText.Replace("Ahoj", "Čau");
            Console.WriteLine($"Pozdrav s Čau: {pozdravPepyCau}");


            string jedlaVcelku = "rezeň, kaleráb, čaj, zemiaky";
            string[] jedla = jedlaVcelku.Split(new string[] {",", " "}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < jedla.Length; i++)
            {
                // int pocetBodiek = 20 - jedla[i].Length;   // vypočíta chýbajúcu dĺžku
                Console.WriteLine(jedla[i].PadLeft(20, '.'));
            }

            string jedlaSoStrednikom = string.Join('\n', jedla);
            Console.WriteLine(jedlaSoStrednikom);

            string posledne4Znaky = "1111";
            Console.WriteLine(posledne4Znaky.PadLeft(16, '*'));

            // vytvorenie cez StringBuilder
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                sb.Append(i);
            }
            Console.WriteLine(sb.ToString());

            // bez sb
            string suhrn = "";
            for (int i = 0; i < 100; i++)
            {
                suhrn += i;
            }
            Console.WriteLine(suhrn);

        }
    }
}
