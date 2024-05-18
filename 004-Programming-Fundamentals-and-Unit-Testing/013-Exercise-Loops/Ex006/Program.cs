namespace Ex006;

internal class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        var tempNumber = n;

        var isSpecialNumber = true;

        while (tempNumber > 0)
        {
            var currentLastDigit = tempNumber % 10;
            tempNumber = tempNumber / 10;

            if (n % currentLastDigit != 0)
            {
                isSpecialNumber = false;
                break;
            }
        }

        if (isSpecialNumber)
            Console.WriteLine($"{n} is special");
        else
            Console.WriteLine($"{n} is not special");
    }
}