﻿using System;
using System.Collections.Generic;

namespace TestApp;

public class AdjacentEqual
{
    public static string Sum(List<int>? numbers)
    {
        var result = new List<int>();

        for (var i = 0; i < numbers.Count; i++)
        {
            if (i == 0 || numbers[i] != numbers[i - 1])
            {
                result.Add(numbers[i]);
                continue;
            }

            result[result.Count - 1] += numbers[i];
        }

        return string.Join(" ", result);
    }
}