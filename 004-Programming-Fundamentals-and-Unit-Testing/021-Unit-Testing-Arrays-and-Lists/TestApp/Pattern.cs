using System;
using System.Linq;

namespace TestApp;

public class Pattern
{
    public static int[] SortInPattern(int[]? arr)
    {
        Array.Sort(arr);

        var distinctList = arr.Distinct().ToArray();

        var result = new int[distinctList.Length];
        var left = 0;
        var right = distinctList.Length - 1;
        var isLeftTurn = true;

        for (var i = 0; i < distinctList.Length; i++)
        {
            if (isLeftTurn)
            {
                result[i] = distinctList[left];
                left++;
            }
            else
            {
                result[i] = distinctList[right];
                right--;
            }

            isLeftTurn = !isLeftTurn;
        }

        return result;
    }
}