namespace Frisdrank
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ingeworpen bedrag is € 2");
            Console.Write("Prijs van de gekozen frisdrank: € ");
            string prijsInput = Console.ReadLine();
            decimal.TryParse(prijsInput, out decimal prijs);
            const decimal muntwaarde = 2;
            decimal wisselgeld = muntwaarde - prijs;
            Console.WriteLine($"Wisselgeld: {wisselgeld:c}");
            
            const decimal munt1euro = 1.00m;
            const decimal munt050 = 0.50m;
            const decimal munt020 = 0.20m;
            const decimal munt010 = 0.10m;
            const decimal munt005 = 0.05m;
            const decimal munt002 = 0.02m;
            const decimal munt001 = 0.01m;

            int aantalMunt1euro = (int)(wisselgeld / munt1euro);
            wisselgeld = wisselgeld % munt1euro;
            Console.WriteLine($"Munten van €1,00: {aantalMunt1euro}");

            
            int aantalMunt050 = (int)(wisselgeld / munt050);
            wisselgeld = wisselgeld % munt050;
            Console.WriteLine($"Munten van €0,50: {aantalMunt050}");

            
            int aantalMunt020 = (int)(wisselgeld / munt020);
            wisselgeld = wisselgeld % munt020;
            Console.WriteLine($"Munten van €0,20: {aantalMunt020}");

            int aantalMunt010 = (int)(wisselgeld / munt010);
            wisselgeld = wisselgeld % munt010;
            Console.WriteLine($"Munten van €0,10: {aantalMunt010}");

            int aantalMunt005 = (int)(wisselgeld / munt005);
            wisselgeld = wisselgeld % munt005;
            Console.WriteLine($"Munten van €0,05: {aantalMunt005}");

            int aantalMunt002 = (int)(wisselgeld / munt002);
            wisselgeld = wisselgeld % munt002;
            Console.WriteLine($"Munten van €0,02: {aantalMunt002}");

            int aantalMunt001 = (int)(wisselgeld / munt001);
            wisselgeld = wisselgeld % munt001;
            Console.WriteLine($"Munten van €0,01: {aantalMunt001}");







        }
    }
}
