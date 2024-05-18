namespace Ex002;

internal class Program
{
    private static void Main(string[] args)
    {
        var sideA = int.Parse(Console.ReadLine()!);

        var area = sideA * sideA;

        Console.WriteLine(area);
    }
}