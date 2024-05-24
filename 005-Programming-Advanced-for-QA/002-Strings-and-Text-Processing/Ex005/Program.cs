using System.Text;

namespace Ex005;

internal class Program
{
    private static void Main(string[] args)
    {
        var input = Console.ReadLine();

        var digits = new StringBuilder();
        var letters = new StringBuilder();
        var others = new StringBuilder();

        foreach (var c in input!)
            if (char.IsDigit(c))
                digits.Append(c);
            else if (char.IsLetter(c))
                letters.Append(c);
            else
                others.Append(c);

        Console.WriteLine(digits);
        Console.WriteLine(letters);
        Console.WriteLine(others);
    }
}