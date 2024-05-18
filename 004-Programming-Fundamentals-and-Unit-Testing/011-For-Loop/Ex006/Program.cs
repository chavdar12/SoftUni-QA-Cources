namespace Ex006;

internal class Program
{
    private static void Main(string[] args)
    {
        var days = int.Parse(Console.ReadLine());

        for (var i = days; i > 0; i--) Console.WriteLine($"{i} days before the exam");
        Console.WriteLine("The exam has come");
    }
}