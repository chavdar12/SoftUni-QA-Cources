namespace Ex004;

internal class Program
{
    private static void Main(string[] args)
    {
        var firstNumber = int.Parse(Console.ReadLine());
        var secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine(firstNumber > secondNumber
            ? $"Greater number: {firstNumber}"
            : $"Greater number: {secondNumber}");
    }
}