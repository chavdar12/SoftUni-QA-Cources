namespace Ex002;

internal class Program
{
    private static void Main(string[] args)
    {
        var numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .Sum();

        Console.WriteLine(numbers);
    }
}