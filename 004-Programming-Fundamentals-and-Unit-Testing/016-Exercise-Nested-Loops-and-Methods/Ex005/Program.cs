﻿namespace Ex005;

internal class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());


        for (var digit1 = 1; digit1 <= 9; digit1++)
        for (var digit2 = 0; digit2 <= 9; digit2++)
        for (var digit3 = 0; digit3 <= 9; digit3++)
        for (var digit4 = 0; digit4 <= 9; digit4++)
            if (digit1 + digit2 == n && digit3 + digit4 == n)
                Console.Write($"{digit1}{digit2}{digit3}{digit4} ");
    }
}