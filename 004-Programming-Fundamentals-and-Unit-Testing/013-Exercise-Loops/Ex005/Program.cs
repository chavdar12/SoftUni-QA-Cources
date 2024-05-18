namespace Ex005;

internal class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        var numbersDividedByModule2 = 0;
        var numbersDividedByModule3 = 0;
        var numbersDividedByModule4 = 0;


        for (var i = 0; i < n; i++)
        {
            var newNumber = int.Parse(Console.ReadLine());

            if (newNumber % 2 == 0) numbersDividedByModule2++;
            if (newNumber % 3 == 0) numbersDividedByModule3++;
            if (newNumber % 4 == 0) numbersDividedByModule4++;
        }

        var numbersDividedByMod2 = (double)numbersDividedByModule2 / n * 100;
        var numbersDividedByMod3 = (double)numbersDividedByModule3 / n * 100;
        var numbersDividedByMod4 = (double)numbersDividedByModule4 / n * 100;

        Console.WriteLine($"{numbersDividedByMod2:F2}%");
        Console.WriteLine($"{numbersDividedByMod3:F2}%");
        Console.WriteLine($"{numbersDividedByMod4:F2}%");
    }
}