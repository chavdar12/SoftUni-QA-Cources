using System;

namespace TestApp;

public class Triangle
{
    public static string PrintTriangle(int size)
    {
        var triangle = string.Empty;

        for (var row = 1; row <= size; row++)
        {
            for (var col = 1; col <= row; col++) triangle += col == row ? col.ToString() : col + " ";

            triangle += Environment.NewLine;
        }

        for (var row = size - 1; row >= 1; row--)
        {
            for (var col = 1; col <= row; col++) triangle += col == row ? col.ToString() : col + " ";

            triangle += Environment.NewLine;
        }

        return triangle.Trim();
    }
}