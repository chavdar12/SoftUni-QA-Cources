namespace Ex003;

internal class Program
{
    private static void Main(string[] args)
    {
        var input = Console.ReadLine().Split();

        var sum = 0;

        foreach (var element in input)
        {
            try
            {
                var number = int.Parse(element);

                sum += number;
            }
            catch (OverflowException)
            {
                Console.WriteLine($"The element '{element}' is out of range!");
            }
            catch (FormatException)
            {
                Console.WriteLine($"The element '{element}' is in wrong format!");
            }
            finally
            {
                Console.WriteLine($"Element '{element}' processed - current sum: {sum}");
            }
        }

        Console.WriteLine($"The total sum of all integers is: {sum}");
    }
}