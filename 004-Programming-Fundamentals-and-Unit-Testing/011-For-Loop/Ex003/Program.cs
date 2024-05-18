namespace Ex003;

internal class Program
{
    private static void Main(string[] args)
    {
        var numberCount = int.Parse(Console.ReadLine());

        double sum = 0;

        for (var i = 1; i <= numberCount; i++)
        {
            var number = double.Parse(Console.ReadLine());

            sum += number;
        }

        Console.WriteLine(sum);
    }
}