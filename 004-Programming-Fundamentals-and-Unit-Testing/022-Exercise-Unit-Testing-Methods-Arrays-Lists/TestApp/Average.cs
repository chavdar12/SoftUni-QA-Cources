using System;

namespace TestApp;

public class Average
{
    public static double CalculateAverage(int[] numbers)
    {
        var sum = 0;

        foreach (var number in numbers) sum += number;

        return (double)sum / numbers.Length;
    }
}