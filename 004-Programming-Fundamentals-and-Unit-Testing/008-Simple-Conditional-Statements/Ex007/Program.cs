namespace Ex007;

internal class Program
{
    private static void Main(string[] args)
    {
        var speed = double.Parse(Console.ReadLine());

        Console.WriteLine(speed <= 30 ? "Slow" : "Fast");
    }
}