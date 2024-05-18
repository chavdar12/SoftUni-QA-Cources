namespace Ex003;

internal class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        PrintTriangle(n);
    }

    private static void PrintLine(int start, int end)
    {
        for (var i = start; i <= end; i++) Console.Write($"{i} ");
        Console.WriteLine();
    }

    private static void PrintTriangle(int size)
    {
        for (var i = 1; i < size; i++) PrintLine(1, i);
        for (var i = size; i >= 1; i--) PrintLine(1, i);
    }
}