namespace Ex002;

internal class Program
{
    private static void Main(string[] args)
    {
        var inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var middle = inputs.Length / 2;

        var firstNumber = inputs[middle - 1];
        var secondNumber = inputs[middle];

        var average = (firstNumber + secondNumber) / 2.0;


        Console.WriteLine($"{average:F2}");
    }
}