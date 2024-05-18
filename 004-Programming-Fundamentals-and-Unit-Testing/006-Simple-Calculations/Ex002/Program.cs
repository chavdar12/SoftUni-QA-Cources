namespace Ex002;

internal class Program
{
    private static void Main(string[] args)
    {
        var numberOne = double.Parse(Console.ReadLine());
        var numberTwo = double.Parse(Console.ReadLine());

        var adding = numberOne + numberTwo;
        var subtraction = numberOne - numberTwo;
        var multiplication = numberOne * numberTwo;
        var division = numberOne / numberTwo;

        Console.WriteLine($"{numberOne:F2} + {numberTwo:F2} = {adding:F2}");
        Console.WriteLine($"{numberOne:F2} - {numberTwo:F2} = {subtraction:F2}");
        Console.WriteLine($"{numberOne:F2} * {numberTwo:F2} = {multiplication:F2}");
        Console.WriteLine($"{numberOne:F2} / {numberTwo:F2} = {division:F2}");
    }
}