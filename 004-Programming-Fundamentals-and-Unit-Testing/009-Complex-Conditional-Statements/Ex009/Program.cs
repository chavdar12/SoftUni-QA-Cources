namespace Ex009;

internal class Program
{
    private static void Main(string[] args)
    {
        var movieType = Console.ReadLine();
        var rowsCount = int.Parse(Console.ReadLine());
        var seatsCount = int.Parse(Console.ReadLine());

        var totalAmount = 0.00;
        double ticketPrice = 0;


        switch (movieType)
        {
            case "Normal":
                ticketPrice = 7.50;
                break;
            case "Premiere":
                ticketPrice = 12.00;
                break;
            case "Discount":
                ticketPrice = 5.00;
                break;
        }

        totalAmount = rowsCount * seatsCount * ticketPrice;
        Console.WriteLine($"{totalAmount:F2}");
    }
}