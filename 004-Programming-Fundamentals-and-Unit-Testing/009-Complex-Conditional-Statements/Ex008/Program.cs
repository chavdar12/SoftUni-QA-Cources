namespace Ex008;

internal class Program
{
    private static void Main(string[] args)
    {
        var numberOne = int.Parse(Console.ReadLine());
        var numberTwo = int.Parse(Console.ReadLine());
        var numberThree = int.Parse(Console.ReadLine());

        if (numberTwo > numberOne && numberThree > numberTwo)
            Console.WriteLine("Ascending");
        else if (numberOne > numberTwo && numberTwo > numberThree)
            Console.WriteLine("Descending");
        else
            Console.WriteLine("Not sorted");
    }
}