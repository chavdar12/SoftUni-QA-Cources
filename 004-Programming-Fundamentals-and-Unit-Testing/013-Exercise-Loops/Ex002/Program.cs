namespace Ex002;

internal class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        for (var i = 1; i <= 10; i++) Console.WriteLine($"{n} x {i} = {n * i}");
    }
}