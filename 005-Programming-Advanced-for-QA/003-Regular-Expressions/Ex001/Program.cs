using System.Text.RegularExpressions;

namespace Ex001;

internal class Program
{
    private static void Main(string[] args)
    {
        var input = Console.ReadLine();
        const string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

        var regex = new Regex(pattern);

        var matches = regex.Matches(input);

        List<string> result = new();

        foreach (Match match in matches) result.Add(match.Value);

        Console.WriteLine(string.Join(" ", result));
    }
}