namespace Ex007;

internal class Program
{
    private static void Main(string[] args)
    {
        var one = char.Parse(Console.ReadLine());
        var two = char.Parse(Console.ReadLine());

        for (var i = one; i <= two; i++) Console.Write(i + " ");
    }
}