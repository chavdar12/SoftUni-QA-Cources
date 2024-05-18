namespace Ex006;

internal class Program
{
    private static void Main(string[] args)
    {
        var inches = int.Parse(Console.ReadLine()!);

        var centimeters = inches * 2.54;

        Console.WriteLine(centimeters);
    }
}