namespace Ex005;

internal class Program
{
    private static void Main(string[] args)
    {
        var rangeEnd = int.Parse(Console.ReadLine());

        for (var i = 1; i <= rangeEnd; i += 3) Console.WriteLine(i);
    }
}