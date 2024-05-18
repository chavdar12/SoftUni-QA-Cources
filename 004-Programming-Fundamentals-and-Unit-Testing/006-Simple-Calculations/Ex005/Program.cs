namespace Ex005;

internal class Program
{
    private static void Main(string[] args)
    {
        var depositedAmount = double.Parse(Console.ReadLine());
        var interestInMonths = int.Parse(Console.ReadLine());
        var annualIntRate = double.Parse(Console.ReadLine());

        var accumulatedInterest = depositedAmount * (annualIntRate / 100);
        var interestPerMonth = accumulatedInterest / 12;
        var totalAmount = depositedAmount + interestInMonths * interestPerMonth;

        Console.WriteLine($"{totalAmount:F2}");
    }
}