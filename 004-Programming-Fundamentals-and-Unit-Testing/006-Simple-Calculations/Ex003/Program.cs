namespace Ex003;

internal class Program
{
    private static void Main(string[] args)
    {
        var tomatoPrice = double.Parse(Console.ReadLine());
        var tomatoQuantity = double.Parse(Console.ReadLine());
        var cucumberPrice = double.Parse(Console.ReadLine());
        var cucumberQuantity = double.Parse(Console.ReadLine());

        var totalTomatoPrice = tomatoPrice * tomatoQuantity;
        var totalCucumberPrice = cucumberPrice * cucumberQuantity;
        var totalCostProducts = totalTomatoPrice + totalCucumberPrice;

        Console.WriteLine($"{totalCostProducts:F2}");
    }
}