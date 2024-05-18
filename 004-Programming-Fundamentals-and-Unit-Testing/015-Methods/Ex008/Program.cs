namespace Ex008;

internal class Program
{
    private static void Main(string[] args)
    {
        var n = Math.Abs(int.Parse(Console.ReadLine()));

        Console.WriteLine(GetMultipleEvenOdds(n));
    }

    private static int GetSumEvenDigits(int number)
    {
        var evenSum = 0;

        while (number > 0)
        {
            var digit = number % 10;
            number /= 10;
            if (digit % 2 == 0) evenSum += digit;
        }

        return evenSum;
    }

    private static int GetSumOddDigits(int number)
    {
        var oddSum = 0;

        while (number > 0)
        {
            var digit = number % 10;
            number /= 10;
            if (digit % 2 != 0) oddSum += digit;
        }

        return oddSum;
    }

    private static int GetMultipleEvenOdds(int number)
    {
        return GetSumEvenDigits(number) * GetSumOddDigits(number);
    }
}