namespace Ex003;

internal class Program
{
    private static void Main(string[] args)
    {
        var firstString = Console.ReadLine();

        var secondString = Console.ReadLine();

        while (secondString.Contains(firstString))
        {
            var wordIndex = secondString.IndexOf(firstString);
            var before = secondString.Substring(0, wordIndex);
            var after = secondString.Substring(wordIndex + firstString.Length);

            secondString = before + after;
        }

        Console.WriteLine(secondString);
    }
}