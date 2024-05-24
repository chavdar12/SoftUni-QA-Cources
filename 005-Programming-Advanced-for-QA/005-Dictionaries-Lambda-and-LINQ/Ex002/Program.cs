namespace Ex002;

internal class Program
{
    private static void Main(string[] args)
    {
        var input = Console.ReadLine();
        string[] words = input.Split(' ');

        Dictionary<string, int> wordCounts = new(StringComparer.OrdinalIgnoreCase);

        foreach (var word in words)
            if (wordCounts.ContainsKey(word.ToLower()))
                wordCounts[word.ToLower()]++;
            else
                wordCounts[word.ToLower()] = 1;

        List<string> result = new();

        foreach (var pair in wordCounts)
            if (pair.Value % 2 != 0)
                result.Add(pair.Key);

        Console.WriteLine(string.Join(" ", result));
    }
}