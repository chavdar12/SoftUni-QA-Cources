using System;

namespace TestApp;

public class EvenOddSubtraction
{
    public static int FindDifference(int[] arr)
    {
        var evenSum = 0;
        var oddSum = 0;

        foreach (var number in arr)
            if (number % 2 == 0)
                evenSum += number;
            else
                oddSum += number;

        return evenSum - oddSum;
    }
}