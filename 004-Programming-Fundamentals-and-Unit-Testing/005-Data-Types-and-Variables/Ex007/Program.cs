namespace Ex007;

internal class Program
{
    private static void Main(string[] args)
    {
        var architectName = Console.ReadLine();
        var totalProjects = int.Parse(Console.ReadLine());

        var projectTime = 3;

        var timeNeeded = totalProjects * projectTime;

        Console.WriteLine($"The architect {architectName} " +
                          $"will need {timeNeeded} hours to complete" +
                          $" {totalProjects} " +
                          $"project/s.");
    }
}