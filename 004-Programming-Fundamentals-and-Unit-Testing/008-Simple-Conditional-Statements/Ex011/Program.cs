namespace Ex011;

internal class Program
{
    private static void Main(string[] args)
    {
        var drinkName = Console.ReadLine();
        var extra = Console.ReadLine();

        const double coffeePrice = 1.00;
        const double teaPrice = 0.60;
        const double sugarPrice = 0.40;

        var finalPrice = drinkName switch
        {
            "coffee" when extra == "sugar" => coffeePrice + sugarPrice,
            "coffee" when extra == "no" => coffeePrice,
            "tea" when extra == "sugar" => teaPrice + sugarPrice,
            "tea" when extra == "no" => teaPrice,
            _ => 0.00
        };

        Console.WriteLine($"Final price: ${finalPrice:F2}");
    }
}