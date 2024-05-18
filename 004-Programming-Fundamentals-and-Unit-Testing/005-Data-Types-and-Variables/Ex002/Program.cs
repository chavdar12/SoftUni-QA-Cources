namespace Ex002;

internal class Program
{
    private static void Main(string[] args)
    {
        var distance = double.Parse(Console.ReadLine());
        var time = double.Parse(Console.ReadLine());

        var speed = distance / time;

        Console.WriteLine($"{speed:F2}");
    }
}