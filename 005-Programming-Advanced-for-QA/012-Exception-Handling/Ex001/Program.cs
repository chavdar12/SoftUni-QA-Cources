namespace Ex001;

internal class Program
{
    private static void Main(string[] args)
    {
        var number = int.Parse(Console.ReadLine());

        try
        {
            if (number < 0) throw new ArgumentOutOfRangeException();

            Console.WriteLine(Math.Sqrt(number));
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid number.");
        }
        finally
        {
            Console.WriteLine("Goodbye.");
        }
    }
}