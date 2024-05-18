namespace Ex001;

internal class Program
{
    private static void Main(string[] args)
    {
        var number = int.Parse(Console.ReadLine());

        NumSign(number);
    }

    static void NumSign(int n)
    {
        switch (n)
        {
            case 0:
                Console.WriteLine($"The number {n} is zero.");
                break;
            case > 0:
                Console.WriteLine($"The number {n} is positive.");
                break;
            default:
                Console.WriteLine($"The number {n} is negative.");
                break;
        }
    }
}