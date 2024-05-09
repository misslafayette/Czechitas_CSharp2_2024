namespace BreakoutRoom_Lesson
{
    // upravte tridu Clovek tak, aby konstruktor vyhodil vyjimku, pokud jmeno neni platne (null nebo prazdny string)
    // nebo pokud tel cislo neni validni (zkontrolujte pocet cislic). Tip: Delku cisla zjistite zavolanim telCislo.ToString().Length.
    // Do metody Main doplnte blok try-catch, ktery uzivatele upozorni, pokud udela chybu
    // muzete pouzit oibecnou tridu Exception, nebno lepe specifickou ArgumentException


    public class Clovek
    {
        public string Jmeno;
        public int TelCislo;
        public Clovek(string jmeno, int telCislo)
        {
            if (string.IsNullOrEmpty(jmeno))
            {
                throw new ArgumentNullException(nameof(Jmeno), "Meno musí byť vyplnené.");
            }


            Jmeno = jmeno;
            TelCislo = telCislo;
            if (TelCislo.ToString().Length != 9);
            {
                throw new ArgumentException("Telefónne číslo musí mať 9 čísel.", nameof(TelCislo));
            }
        }
        public string VypisJmenoACislo()
        {
            return $"{Jmeno}: {TelCislo}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program na vytvareni telefonniho seznamu");
            Console.WriteLine("========================================");
            Console.Write("Zadejte jmeno: ");
            string jmeno = Console.ReadLine();
            Console.Write("Zadejte telefonni cislo: ");
            string cislo = Console.ReadLine();

            try
            {
                Clovek prvniClovek = new Clovek(jmeno, int.Parse(cislo));
                Console.WriteLine(prvniClovek.VypisJmenoACislo());
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine($"Chyba zadaných údajov: {argEx.Message}");
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Neznama Chyba: {ex.Message}");
            }
            finally
            {
                Console.WriteLine($"Vkladanie telefónneho čísla bolo dokončené.");
            }

            Console.ReadLine();
        }
    }
}
