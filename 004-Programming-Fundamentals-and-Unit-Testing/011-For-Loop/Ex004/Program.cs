namespace Ex004;

internal class Program
{
    private static void Main(string[] args)
    {
        var number = int.Parse(Console.ReadLine());

        for (var i = 7; i <= number; i += 10) Console.WriteLine(i);
    }
}