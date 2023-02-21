namespace Kolekcje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            City c = new City("Poznan", "185", "polen", 560000, 2, 1);

            string fP = @"C:\\Users\\student\\Desktop\\VS\\Kolekcje\\csv\\pop.csv";

            CSVReader cr = new CSVReader(fP);
            City[] ?cities = cr.ReadFirstNCities(5);
            
            StreamReader sr = new StreamReader(fP);
            string line = sr.ReadLine();
            City ci = cr.ReadCityFromCSVLine(line);
            Console.WriteLine(ci.cityName);
        }
        void older()
        {
            string styczen = "januaring";
            Console.WriteLine($"pierfszy miesiąc : {styczen}");

            string[] monthsOfYear =
            {
                "Styczeń",
                "Luty",
                "Marzec",
                "Kwiecień",
                "Maj",
                "Czerwiec",
                "Lipiec",
                "Sierpień",
                "Wrzesień",
                "Październik",
                "Listopad",
                "Grudzień"
            };
            Console.WriteLine(monthsOfYear[0]);
            foreach (string monthOfYear in monthsOfYear)
            {
                Console.WriteLine(monthOfYear);
            }
            foreach (var monthOfYear in monthsOfYear)
            {
                Console.WriteLine(monthOfYear);
            }

            int[] arrayInt = { 1, 2, 3, 4 };
            char[] arrayChar = { 'A', 'B', 'C' };
            Console.Clear();
            Console.WriteLine("1-styczen itd");
            int read = int.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine(monthsOfYear[read - 1]);
        }
    }
}