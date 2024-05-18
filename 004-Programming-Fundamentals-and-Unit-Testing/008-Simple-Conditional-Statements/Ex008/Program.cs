namespace Ex008;

internal class Program
{
    private static void Main(string[] args)
    {
        var ticketType = Console.ReadLine();

        switch (ticketType)
        {
            case "student":
                Console.WriteLine("$1.00");
                break;
            case "regular":
                Console.WriteLine("$1.60");
                break;
            default:
                Console.WriteLine("Invalid ticket type!");
                break;
        }
    }
}