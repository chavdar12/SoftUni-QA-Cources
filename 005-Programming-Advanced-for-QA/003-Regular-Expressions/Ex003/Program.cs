using System.Text.RegularExpressions;

namespace Ex003;

internal class Program
{
    private static void Main(string[] args)
    {
        var input = Console.ReadLine();

        var pattern = @"(?'day'\d{2})(?'del'[\/\.\-])(?'month'[A-Z][a-z]{2})\'del'(?'year'\d{4})";

        var regex = new Regex(pattern);

        var matches = regex.Matches(input);

        var validDates = new List<string>();

        foreach (Match match in matches)
        {
            var day = match.Groups["day"].Value;
            var month = match.Groups["month"].Value;
            var year = match.Groups["year"].Value;

            validDates.Add($"Day: {day}, Month: {month}, Year: {year}");
        }

        Console.WriteLine(string.Join(Environment.NewLine, validDates));
    }
}