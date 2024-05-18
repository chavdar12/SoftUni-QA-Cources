namespace Ex003;

internal class Program
{
    private static void Main(string[] args)
    {
        var points = int.Parse(Console.ReadLine());

        int bonusPoints;
        var totalPointsWithBonus = 0;

        switch (points)
        {
            case >= 0 and <= 3:
                bonusPoints = 5;
                totalPointsWithBonus = points + bonusPoints;
                break;
            case >= 4 and <= 6:
                bonusPoints = 15;
                totalPointsWithBonus = points + bonusPoints;
                break;
            case >= 7 and <= 9:
                bonusPoints = 20;
                totalPointsWithBonus = points + bonusPoints;
                break;
        }

        Console.WriteLine(totalPointsWithBonus);
    }
}