namespace Ex003;

internal class Program
{
    private static void Main(string[] args)
    {
        var radius = double.Parse(Console.ReadLine());

        var area = radius * radius * Math.PI;
        var perimeter = 2 * Math.PI * radius;

        Console.WriteLine($"Area = {area:F2}");
        Console.WriteLine($"Perimeter = {perimeter:F2}");
    }
}