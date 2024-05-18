namespace Ex004;

internal class Program
{
    private static void Main(string[] args)
    {
        var startLetter = char.Parse(Console.ReadLine());
        var endLetter = char.Parse(Console.ReadLine());
        var excludedLetter = char.Parse(Console.ReadLine());


        var count = 0;


        for (var letter1 = startLetter; letter1 <= endLetter; letter1++)
        for (var letter2 = startLetter; letter2 <= endLetter; letter2++)
        for (var letter3 = startLetter; letter3 <= endLetter; letter3++)
            if (letter1 != excludedLetter && letter2 != excludedLetter && letter3 != excludedLetter)
            {
                Console.Write($"{letter1}{letter2}{letter3} ");
                count++;
            }

        Console.WriteLine();
        Console.WriteLine(count);
    }
}