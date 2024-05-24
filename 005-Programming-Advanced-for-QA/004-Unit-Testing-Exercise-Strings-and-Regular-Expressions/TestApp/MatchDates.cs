using System;
using System.Text.RegularExpressions;

namespace TestApp;

public class MatchDates
{
    public static string Match(string? dates)
    {
        if (dates is null) throw new ArgumentException("Input cannot be null!");

        Regex pattern = new(@"\b(?<day>\d{2})(?<seperator>[-.\/])(?<month>[A-Z][a-z]+)\k<seperator>(?<year>\d{4})");

        var matches = pattern.Matches(dates);
        foreach (Match match in matches)
        {
            var day = match.Groups["day"].Value;
            var month = match.Groups["month"].Value;
            var year = match.Groups["year"].Value;

            return $"Day: {day}, Month: {month}, Year: {year}";
        }

        return string.Empty;
    }
}