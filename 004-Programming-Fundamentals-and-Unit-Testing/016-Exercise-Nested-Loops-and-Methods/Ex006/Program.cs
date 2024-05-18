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

            if (symbol == 'A' || symbol == 'a'
                              || symbol == 'E' || symbol == 'e'
                              || symbol == 'I' || symbol == 'i'
                              || symbol == 'O' || symbol == 'o'
                              || symbol == 'U' || symbol == 'u')
                count++;
        }


        return count;
    }
}