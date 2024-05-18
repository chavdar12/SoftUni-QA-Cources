namespace Ex005;

internal class Program
{
    private static void Main(string[] args)
    {
        var sideA = int.Parse(Console.ReadLine()!);
        var sideB = int.Parse(Console.ReadLine()!);
        var sideC = int.Parse(Console.ReadLine()!);

        var area = sideA + sideB + sideC;

        Console.WriteLine(area);
    }
}