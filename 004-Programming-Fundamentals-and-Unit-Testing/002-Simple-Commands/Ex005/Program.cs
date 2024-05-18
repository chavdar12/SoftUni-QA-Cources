namespace Ex005;

internal class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine()!);
        for (var i = 1; i <= n; i++)
        {
            for (var a = 1; a <= n; a++) Console.Write("* ");

            Console.WriteLine();
        }

        Console.WriteLine("Hello, SoftUni");
    }
}