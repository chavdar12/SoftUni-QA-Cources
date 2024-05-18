namespace Ex005;

internal class Program
{
    private static void Main(string[] args)
    {
        var number = int.Parse(Console.ReadLine());

        if (!((number >= 100 && number <= 200) || number == 0)) Console.WriteLine("invalid");
    }
}