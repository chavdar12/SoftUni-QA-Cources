namespace Ex002;

internal class Program
{
    private static void Main(string[] args)
    {
        var words = Console.ReadLine().Split().ToArray();

        var result = words.Aggregate("", (current1, word) =>
            word.Aggregate(current1, (current, _) => current + word));

        Console.WriteLine(result);
    }
}