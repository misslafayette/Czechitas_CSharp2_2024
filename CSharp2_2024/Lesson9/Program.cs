namespace Lesson9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("prvySubor.txt", "Toto je prvý text zapísaný do súboru."); //zapise do zlozky kde je EXE

            string cestaKSuboru = @"C:\Users\source\repos\CSharp2_2024\Lekce9_Files\druhysubor.txt";

            string mojeDokumenty = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // cesta k dokumentu
            var tretiaCestaKSuboru = Path.Combine(mojeDokumenty, "tretiSubor.txt");
            File.WriteAllText(tretiaCestaKSuboru, "Toto je treti text zapisany do suboru (podruhe)");

            File.AppendAllText(tretiaCestaKSuboru, Environment.NewLine);
            File.AppendAllText(tretiaCestaKSuboru, "Toto je prvy dodatok.");

            var stvrtySubor = Path.Combine(mojeDokumenty, "stvrtySubor.txt");
            StreamWriter writer = new StreamWriter(stvrtySubor, append: true);
            writer.WriteLine("Toto je prvý riadok");
            writer.WriteLine("Toto je druhý riadok");
            writer.WriteLine("Toto je treti riadok");
            writer.Flush(); // zapise obsah medzipamati na disk
            writer.WriteLine("Toto je štvrtý riadok");
            writer.WriteLine("Toto je piaty riadok");
            writer.Close(); // uzavrie stream - dolezite nezabudnut, inak mozeme prist o data

            string[] nacitamTreti = File.ReadAllLines(tretiaCestaKSuboru);
            foreach (string riadok in  nacitamTreti)
            {
                Console.WriteLine(riadok);
            }

            string cestaKNoveSlozce = Path.Combine(mojeDokumenty, "MojeSlozka");
            Directory.CreateDirectory(cestaKNoveSlozce);
            if (Directory.Exists(cestaKNoveSlozce))
            {
                Console.WriteLine($"Adresar {cestaKNoveSlozce} existuje");
            }
            else
            {
                Console.WriteLine($"Adresar {cestaKNoveSlozce} neexistuje");
            }

            string cestaKSuboruVNovejZlozke = Path.Combine(mojeDokumenty, "MojaZlozka");
            Directory.CreateDirectory(cestaKSuboruVNovejZlozke);
            
            if (File.Exists(cestaKSuboruVNovejZlozke))
            {
                Console.WriteLine($"Súbor {cestaKSuboruVNovejZlozke} existuje.");
            }
            else
            {
                Console.WriteLine($"Súbor {cestaKSuboruVNovejZlozke} neexistuje."); 
            }

            // Zapisanie do novej zlozky (musi ale byt uz vytvorena)
            File.WriteAllText(cestaKSuboruVNovejZlozke, "Toto je piaty text zapsany do souboru");


            // Streamy jednoduchsie
            var siestySubor = Path.Combine(mojeDokumenty, "siestySubor.txt");
            using (StreamWriter writer3 = new StreamWriter(siestySubor))
            {
                writer3.WriteLine("Prvy riadok z usingu");
                writer3.WriteLine("Druhy riadok z usingu");
            }

            StreamWriter writer2 = new StreamWriter(siestySubor);
            try
            {
                writer2.WriteLine("Prvy riadok z tryCatch");
                writer2.WriteLine("Druhy riadok z tryCatch");
            }
            finally
            {
                writer2.Dispose();
            }
        }
    }
}
