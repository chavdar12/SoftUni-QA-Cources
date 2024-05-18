namespace Ex001;

internal class Program
{
    private static void Main(string[] args)
    {
        var dollars = double.Parse(Console.ReadLine());

        var convert = dollars * 0.88;

        Console.WriteLine($"{convert:F2}");
    }
}