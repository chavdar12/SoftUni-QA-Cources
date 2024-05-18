namespace Ex006;

internal class Program
{
    private static void Main(string[] args)
    {
        var waterTemperature = int.Parse(Console.ReadLine());

        Console.WriteLine(waterTemperature > 100 ? "The water is boiling" : "The water is not hot enough");
    }
}