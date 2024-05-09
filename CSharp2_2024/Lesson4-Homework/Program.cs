namespace Lesson4_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Vypiš aktuální datum a čas, nemusíš řešit, v kterém je to časovém pásmu.

            Console.WriteLine(DateTime.Now);
            Console.WriteLine();

            // 2. Vytvoř proměnnou typu DateTime a ulož do ní svoje datum narození. Potom vypiš, kolik dnů od té doby uteklo.

            DateTime birthday = new DateTime(1994, 10, 25);
            Console.WriteLine($"It's been {(DateTime.Now - birthday).Days} days since I was born.");
            Console.WriteLine();

            // 3. Vytvoř list stringů a vlož do něj 5 různých hodnot.

            List<string> bookCharacters = new List<string>() { "Elise", "Lynette", "Stella", "Michel", "Lucille"};

            // 4. Smaž z tohoto listu libovolnou hodnotu.

            bookCharacters.Remove("Lucille");

            // 5. Zjisti, jestli tento list obsahuje nějakou hodnotu pomocí list metody Contains

            bool isOnList = bookCharacters.Contains("Stella");
            if (isOnList)
            {
                Console.WriteLine("She's there.");
            }
            else
            {
                Console.WriteLine($"The list doesn't contain 'Stella'.");
            }
            Console.WriteLine();

            // 6. Vypiš do konzole, kolik je v tom listu prvků a připoj k tomu všechny ty hodnoty (např: "2: modra, zelena").

            Console.WriteLine($"The list contains {bookCharacters.Count} items:");
            foreach ( string character in bookCharacters )
            {
                Console.WriteLine($"Index {bookCharacters.IndexOf(character)} : character named {character}");
            }
            Console.WriteLine();

            // 7. Vytvoř slovník, kde klíčem bude položka nákupu (string) a hodnotou cena té položky, a vlož nějaké hodnoty (např: <"chleba", 20>).

            Dictionary<string, int> groceries = new Dictionary<string, int>();

            groceries.Add("bread", 20);
            groceries.Add("tea", 25);
            groceries.Add("eggs", 30);

            // 8. Zjisti, jestli slovník obsahuje nějakou konkrétní potravinu a pokud ano, vypiš její cenu, pokud ne, vypiš, že není.

            bool isInStock = groceries.ContainsKey("bread");
            if (groceries.ContainsKey("bread"))
            {
                Console.WriteLine($"The price of bread is {groceries["bread"]} czk.");
            }
            else
            {
                Console.WriteLine("'Bread' is not on the list.");
            }
            Console.WriteLine();

            // 9. Řekněme, že už jsi do slovníku přidala např. chleba a zjistila, že máš v nákupní tašce ještě jeden
            // -> uprav hodnotu k tomu klíči tak, aby obsahovala hromadnou cenu za všechny stejné položky.

            groceries["bread"] = groceries["bread"]*2;
            Console.WriteLine($"The price of bread is {groceries["bread"]} czk.");

        }
    }
}
