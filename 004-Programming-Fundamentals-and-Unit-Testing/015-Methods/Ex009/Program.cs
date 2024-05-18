namespace Ex009;

internal class Program
{
    private static void Main(string[] args)
    {
        var product = Console.ReadLine();
        var quantity = int.Parse(Console.ReadLine());

        var finalPrice = GetFinalPrice(product, quantity);

        Console.WriteLine($"{finalPrice:F2}");
    }

    private static double GetFinalPrice(string prod, int quant)
    {
        var singleProductPrice = prod switch
        {
            "coffee" => 1.50,
            "water" => 1.00,
            "coke" => 1.40,
            "snacks" => 2.00,
            _ => 0
        };
        return singleProductPrice * quant;
    }
}