namespace Ex003;

internal class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        Dictionary<string, List<string>> synonyms = new();

        for (var i = 0; i < n; i++)
        {
            var word = Console.ReadLine();
            var synonym = Console.ReadLine();

            if (!synonyms.ContainsKey(word)) synonyms[word] = new List<string>();

            synonyms[word].Add(synonym);
        }

        foreach (var pair in synonyms)
        {
            var word = pair.Key;
            var synonymsList = string.Join(", ", pair.Value);
            Console.WriteLine($"{word} - {synonymsList}");
        }
    }
}