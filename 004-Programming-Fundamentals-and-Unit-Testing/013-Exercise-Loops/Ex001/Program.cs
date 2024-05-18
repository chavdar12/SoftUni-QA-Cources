namespace Ex001;

internal class Program
{
    private static void Main(string[] args)
    {
        var number = int.Parse(Console.ReadLine());
        var power = int.Parse(Console.ReadLine());

        var sum = 1;

        for (var i = 0; i < power; i++) sum *= number;
        Console.WriteLine(sum);
    }
}