namespace Ex001;

internal class Program
{
    private static void Main(string[] args)
    {
        var days = int.Parse(Console.ReadLine());

        const int day = 24 * 60;
        var daysInMinutes = days * day;

        Console.WriteLine($"Minutes = {daysInMinutes}");
    }
}