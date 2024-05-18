namespace Ex010;

internal class Program
{
    private static void Main(string[] args)
    {
        var sideA = int.Parse(Console.ReadLine());
        var sideB = int.Parse(Console.ReadLine());
        var sideC = int.Parse(Console.ReadLine());

        if (sideA < sideB + sideC)
            Console.WriteLine("Valid Triangle");
        else if (sideB < sideA + sideC)
            Console.WriteLine("Valid Triangle");
        else if (sideC < sideA + sideB)
            Console.WriteLine("Valid Triangle");
        else
            Console.WriteLine("Invalid Triangle");
    }
}