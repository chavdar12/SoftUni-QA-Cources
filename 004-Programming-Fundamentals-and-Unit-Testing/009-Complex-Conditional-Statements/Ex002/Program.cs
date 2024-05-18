namespace Ex002;

internal class Program
{
    private static void Main(string[] args)
    {
        var numberOne = int.Parse(Console.ReadLine());
        var numberTwo = int.Parse(Console.ReadLine());
        var numberThree = int.Parse(Console.ReadLine());

        if (numberOne > numberTwo)
        {
            Console.WriteLine(numberOne > numberThree ? numberOne : numberThree);
        }
        else
        {
            Console.WriteLine(numberTwo > numberThree ? numberTwo : numberThree);
        }
    }
}