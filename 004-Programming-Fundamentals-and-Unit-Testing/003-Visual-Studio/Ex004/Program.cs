namespace Ex004;

internal class Program
{
    private static void Main(string[] args)
    {
        var firstName = Console.ReadLine();
        var lastName = Console.ReadLine();
        var country = Console.ReadLine();
        var town = Console.ReadLine();

        Console.WriteLine($"{firstName} {lastName} from {country} - {town}!");
    }
}