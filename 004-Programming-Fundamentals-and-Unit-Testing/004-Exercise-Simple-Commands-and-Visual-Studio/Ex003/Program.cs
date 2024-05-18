namespace Ex003;

internal class Program
{
    private static void Main(string[] args)
    {
        var length = int.Parse(Console.ReadLine()!);
        var height = int.Parse(Console.ReadLine()!);

        var area = length * height;

        Console.WriteLine(area);
    }
}