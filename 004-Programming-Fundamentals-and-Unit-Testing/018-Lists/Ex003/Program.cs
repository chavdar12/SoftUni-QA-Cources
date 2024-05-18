namespace Ex003;

internal class Program
{
    private static void Main(string[] args)
    {
        var numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        for (var i = 0; i < numbers.Count; i++)
        {
            var currentNumber = numbers[i];
            if (currentNumber >= 0) continue;
            numbers.Remove(currentNumber);
            i--;
        }

        if (numbers.Count > 0)
        {
            numbers.Reverse();
            Console.WriteLine(string.Join(" ", numbers));
        }
        else
        {
            Console.WriteLine("empty");
        }
    }
}