namespace Ex006;

internal class Program
{
    private static void Main(string[] args)
    {
        var numbersOne = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        var numbersTwo = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();


        for (var i = 0; i < numbersOne.Length; i++)
        for (var j = 0; j < numbersTwo.Length; j++)
            if (numbersOne[i] == numbersTwo[j])
                Console.Write($"{numbersOne[i]} ");
        Console.WriteLine();
    }
}