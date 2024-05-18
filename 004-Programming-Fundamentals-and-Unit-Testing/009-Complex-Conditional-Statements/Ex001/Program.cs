namespace Ex001;

internal class Program
{
    private static void Main(string[] args)
    {
        var product = Console.ReadLine();
        var day = Console.ReadLine();

        switch (product)
        {
            case "Banana":
                Console.WriteLine(day == "Weekday" ? "2.50" : "2.70");
                break;
            case "Apple":
                Console.WriteLine(day == "Weekday" ? "1.30" : "1.60");
                break;
            case "Kiwi":
                Console.WriteLine(day == "Weekday" ? "2.20" : "3.00");
                break;
        }
    }
}