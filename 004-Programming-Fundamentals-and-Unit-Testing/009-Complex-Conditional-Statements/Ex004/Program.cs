﻿namespace Ex004;

internal class Program
{
    private static void Main(string[] args)
    {
        var product = Console.ReadLine();

        switch (product)
        {
            case "curry":
            case "noodles":
            case "sushi":
            case "spaghetti":
            case "bread":
                Console.WriteLine("food");
                break;

            case "tea":
            case "water":
            case "coffee":
            case "juice":

                Console.WriteLine("drink");
                break;
            default:
                Console.WriteLine("unknown");

                break;
        }
    }
}