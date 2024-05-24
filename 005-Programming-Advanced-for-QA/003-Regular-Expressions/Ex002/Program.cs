using System.Text.RegularExpressions;

namespace Ex002;

internal class Program
{
    private static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var pattern = @"\+359([\ \-])2\1\d{3}\1\d{4}";

        var regex = new Regex(pattern);

        var matches = regex.Matches(input);

        var validNumbers = new List<string>();

        foreach (Match match in matches) validNumbers.Add(match.Value);

        Console.WriteLine(string.Join(", ", validNumbers));
    }
}