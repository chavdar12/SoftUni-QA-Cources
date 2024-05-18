namespace Ex001;

internal class Program
{
    private static void Main(string[] args)
    {
        var numberOne = int.Parse(Console.ReadLine());
        var numberTwo = int.Parse(Console.ReadLine());

        for (var i = numberOne; i <= numberTwo; i++) Console.WriteLine(i);
    }
}