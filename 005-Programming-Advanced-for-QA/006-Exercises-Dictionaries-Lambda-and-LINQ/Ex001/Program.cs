namespace Ex001;

internal class Program
{
    private static void Main(string[] args)
    {
        var input = Console.ReadLine();

        var characters = new Dictionary<char, int>();

        foreach (var ch in input.Where(ch => ch != ' ').Where(ch => !characters.TryAdd(ch, 1)))
            characters[ch]++;

        foreach (var pair in characters) Console.WriteLine($"{pair.Key} -> {pair.Value}");
    }
}