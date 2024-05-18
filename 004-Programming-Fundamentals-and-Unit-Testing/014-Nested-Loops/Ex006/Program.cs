namespace Ex006;

internal class Program
{
    private static void Main(string[] args)
    {
        var text = Console.ReadLine();

        var countVowels = GetVowelsCount(text);
        Console.WriteLine(countVowels);
    }

    private static int GetVowelsCount(string text)
    {
        var count = 0;

        for (var position = 0; position <= text.Length - 1; position++)
        {
            var symbol = text[position];

            if (symbol is 'A' or 'a' or 'E' or 'e' or 'I' or 'i' or 'O' or 'o' or 'U' or 'u')
                count++;
        }


        return count;
    }
}