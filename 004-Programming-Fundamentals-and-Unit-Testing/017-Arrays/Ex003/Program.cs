namespace Ex003;

internal class Program
{
    private static void Main(string[] args)
    {
        var size = int.Parse(Console.ReadLine());

        var numbers = new int[size];

        for (var i = 0; i < numbers.Length; i++) numbers[i] = int.Parse(Console.ReadLine());

        for (var i = numbers.Length - 1; i >= 0; i--) Console.Write($"{numbers[i]} ");
    }
}