namespace Ex001;

internal class Program
{
    private static void Main(string[] args)
    {
        var number = int.Parse(Console.ReadLine());

        var sum = 0;


        while (number > 0)
        {
            var digit = number % 10;
            number /= 10;

            if (digit % 2 != 0) continue;
            var factorial = 1;

            for (var i = 1; i <= digit; i++) factorial *= i;
            sum += factorial;
        }

        Console.WriteLine(sum);
    }
}