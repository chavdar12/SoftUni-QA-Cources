namespace Ex004;

internal class Program
{
    private static void Main(string[] args)
    {
        var sideA = int.Parse(Console.ReadLine()!);
        var sideB = int.Parse(Console.ReadLine()!);
        var height = int.Parse(Console.ReadLine()!);

        var area = (sideA + sideB) / 2 * height;

        Console.WriteLine(area);
    }
}