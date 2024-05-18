namespace Ex004;

internal class Program
{
    private static void Main(string[] args)
    {
        var distanceMeters = double.Parse(Console.ReadLine());

        const double kilometer = 1000;
        var metersPerKilometer = distanceMeters / kilometer;

        Console.WriteLine($"{metersPerKilometer:F2}");
    }
}