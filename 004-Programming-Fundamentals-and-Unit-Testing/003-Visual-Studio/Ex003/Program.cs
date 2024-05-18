namespace Ex003;

internal class Program
{
    private static void Main(string[] args)
    {
        var firstName = Console.ReadLine();
        var lastName = Console.ReadLine();
        var email = Console.ReadLine();

        Console.WriteLine($"Customer: {firstName} {lastName} ({email})");
    }
}