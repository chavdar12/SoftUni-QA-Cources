namespace Ex005;

internal class Program
{
    private static void Main(string[] args)
    {
        var text = Console.ReadLine();
        var number = int.Parse(Console.ReadLine());

        Console.WriteLine(RepeatString(text, number));
    }

    private static string RepeatString(string input, int count)
    {
        var output = "";

        for (var i = 1; i <= count; i++) output += input;


        return output;
    }
}