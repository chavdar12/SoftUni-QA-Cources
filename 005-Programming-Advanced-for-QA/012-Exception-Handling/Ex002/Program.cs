namespace Ex002;

internal class Program
{
    private static void Main(string[] args)
    {
        var numbers = new List<int>();

        var start = 1;

        while (numbers.Count < 10)
            try
            {
                var currentNumber = ReadNumber(start, 100);

                numbers.Add(currentNumber);
                start = currentNumber;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine($"Your number is not in range {start} - 100!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Number!");
            }

        Console.WriteLine(string.Join(", ", numbers));
    }

    private static int ReadNumber(int start, int end)
    {
        var number = int.Parse(Console.ReadLine());

        if (number <= start || number >= end) throw new ArgumentOutOfRangeException();

        return number;
    }
}