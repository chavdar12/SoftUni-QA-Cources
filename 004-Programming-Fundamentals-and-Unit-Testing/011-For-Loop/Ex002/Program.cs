namespace Ex002;

internal class Program
{
    private static void Main(string[] args)
    {
        var number = int.Parse(Console.ReadLine());

        var sum = 0;

        for (var i = 1; i <= number; i++) sum += i;
        for (var i = 1; i < number; i++) Console.Write($"{i}+");
        Console.Write(number);
        Console.WriteLine($"={sum}");
    }
}