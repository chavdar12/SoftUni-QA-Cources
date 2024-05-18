namespace Ex004;

internal class Program
{
    private static void Main(string[] args)
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var oddSum = 0;
        var evenSum = 0;


        foreach (var number in numbers)
            if (number % 2 == 0)
                evenSum += number;
            else
                oddSum += number;

        var diff = evenSum - oddSum;

        Console.WriteLine(diff);
    }
}