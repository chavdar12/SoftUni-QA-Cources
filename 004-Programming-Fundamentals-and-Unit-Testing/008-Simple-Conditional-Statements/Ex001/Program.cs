namespace Ex001;

internal class Program
{
    private static void Main(string[] args)
    {
        var temperature = int.Parse(Console.ReadLine());

        if (temperature < 0) Console.WriteLine("Freezing weather!");
    }
}