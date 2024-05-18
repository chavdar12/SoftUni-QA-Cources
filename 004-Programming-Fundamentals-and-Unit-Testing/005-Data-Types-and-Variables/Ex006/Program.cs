namespace Ex006;

internal class Program
{
    private static void Main(string[] args)
    {
        var packagesDogFood = int.Parse(Console.ReadLine());
        var packagesCatFood = int.Parse(Console.ReadLine());

        var dogFoodPrice = packagesDogFood * 2.50;
        var catFoodPrice = packagesCatFood * 4.00;

        var expenses = dogFoodPrice + catFoodPrice;

        Console.WriteLine($"{expenses:F2} lv.");
    }
}