namespace Ex006;

internal class Program
{
    private static void Main(string[] args)
    {
        var baseNumber = int.Parse(Console.ReadLine());
        var power = int.Parse(Console.ReadLine());

        Console.WriteLine(MathPower(baseNumber, power));
    }

    private static int MathPower(int number, int powerNumber)
    {
        var output = number;

        for (var i = 2; i <= powerNumber; i++) output *= number;

        return output;
    }
}