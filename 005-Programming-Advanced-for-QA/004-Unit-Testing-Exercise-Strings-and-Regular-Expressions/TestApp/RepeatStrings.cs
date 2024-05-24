using System.Linq;
using System.Text;

namespace TestApp;

public class RepeatStrings
{
    public static string Repeat(string[] input)
    {
        StringBuilder sb = new();

        foreach (var s in input)
        {
            var repeatedString = string.Concat(Enumerable.Repeat(s, s.Length));
            sb.Append(repeatedString);
        }

        return sb.ToString().Trim();
    }
}