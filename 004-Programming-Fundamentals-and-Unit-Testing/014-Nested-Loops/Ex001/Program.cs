namespace Ex001;

internal class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        for (var firstNumber = 2; firstNumber <= n; firstNumber += 2)
        for (var secondNumber = 1; secondNumber <= n; secondNumber += 2)
            Console.Write($"{firstNumber}{secondNumber}{firstNumber * secondNumber} ");
    }
}