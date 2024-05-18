namespace Ex003;

internal class Program
{
    private static void Main(string[] args)
    {
        var maxFirst = int.Parse(Console.ReadLine());
        var maxSecond = int.Parse(Console.ReadLine());
        var maxThird = int.Parse(Console.ReadLine());


        for (var firstDigit = 2; firstDigit <= maxFirst; firstDigit += 2)
        for (var secondDigit = 1; secondDigit <= maxSecond; secondDigit++)
        for (var thirdDigit = 2; thirdDigit <= maxThird; thirdDigit += 2)
            if (secondDigit == 2 || secondDigit == 3 || secondDigit == 5 || secondDigit == 7)
                Console.WriteLine($"{firstDigit}{secondDigit}{thirdDigit}");
    }
}