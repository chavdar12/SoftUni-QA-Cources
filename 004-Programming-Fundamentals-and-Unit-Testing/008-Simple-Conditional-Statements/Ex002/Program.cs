namespace Ex002;

internal class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        Console.WriteLine(n % 2 == 0 ? "even" : "odd");
    }
}