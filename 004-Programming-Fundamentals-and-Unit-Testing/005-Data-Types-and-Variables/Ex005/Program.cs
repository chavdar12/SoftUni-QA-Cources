namespace Ex005;

internal class Program
{
    private static void Main(string[] args)
    {
        var tempCelsius = double.Parse(Console.ReadLine());

        var tempFahrenheit = tempCelsius * 1.8 + 32;

        Console.WriteLine($"{tempFahrenheit:F2}");
    }
}