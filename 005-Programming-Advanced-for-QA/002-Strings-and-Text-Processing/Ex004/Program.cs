namespace Ex004;

internal class Program
{
    private static void Main(string[] args)
    {
        var bannedWords = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

        var text = Console.ReadLine();

        foreach (var bannedWord in bannedWords)
        {
            var asterisks = new string('*', bannedWord.Length);

            text = text.Replace(bannedWord, asterisks);
        }

        Console.WriteLine(text);
    }
}