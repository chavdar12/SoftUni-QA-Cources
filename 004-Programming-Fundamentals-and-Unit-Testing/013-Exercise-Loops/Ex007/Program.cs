namespace Ex007;

internal class Program
{
    private static void Main(string[] args)
    {
        var stopNumber = int.Parse(Console.ReadLine());

        var previousNumber = 0;
        int currentNumber;

        while (true)
        {
            currentNumber = int.Parse(Console.ReadLine());

            if (currentNumber == stopNumber) break;

            previousNumber = currentNumber;
        }

        var bonusValue = previousNumber * 0.2;
        var bonusResult = previousNumber + bonusValue;

        Console.WriteLine(bonusResult);
    }
}