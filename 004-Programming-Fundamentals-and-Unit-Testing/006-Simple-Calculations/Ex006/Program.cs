namespace Ex006;

internal class Program
{
    private static void Main(string[] args)
    {
        var numberOfPages = int.Parse(Console.ReadLine());
        var pagesRead = int.Parse(Console.ReadLine());
        var daysNeeded = int.Parse(Console.ReadLine());

        var totalReadingTime = numberOfPages / pagesRead;
        var totalHoursReading = totalReadingTime / daysNeeded;

        Console.WriteLine(totalHoursReading);
    }
}