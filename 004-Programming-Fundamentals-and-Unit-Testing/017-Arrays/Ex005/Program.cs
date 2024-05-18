namespace Ex005;

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


        var isIdentical = !numbersOne.Where((t, i) => t != numbersTwo[i]).Any();

        Console.WriteLine(isIdentical ? "Arrays are identical." : "Arrays are not identical.");
    }
}