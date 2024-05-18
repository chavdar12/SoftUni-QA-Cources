namespace Ex007;

internal class Program
{
    private static void Main(string[] args)
    {
        var firstNumber = int.Parse(Console.ReadLine());
        var secondNumber = int.Parse(Console.ReadLine());


        var factFirstNumber = CalculateFactorial(firstNumber);


        var factSecondNumber = CalculateFactorial(secondNumber);


        Console.WriteLine(factFirstNumber / factSecondNumber);
    }

    private static int CalculateFactorial(int number)
    {
        var fact = 1;
        for (var i = 1; i <= number; i++) fact = fact * i;

        return fact;
    }
}