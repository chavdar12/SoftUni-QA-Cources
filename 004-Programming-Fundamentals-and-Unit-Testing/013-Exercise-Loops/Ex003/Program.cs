namespace Ex003;

internal class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        var maxNumber = int.MinValue;


        for (var i = 1; i <= n; i++)
        {
            var newNumber = int.Parse(Console.ReadLine());

            if (newNumber > maxNumber) maxNumber = newNumber;
        }

        Console.WriteLine(maxNumber);
    }
}