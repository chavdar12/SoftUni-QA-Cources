namespace Ex001;

internal class Program
{
    private static void Main(string[] args)
    {
        var numbers = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToList();

        var counter = new SortedDictionary<double, int>();

        foreach (var number in numbers)
            if (counter.ContainsKey(number))
                counter[number]++;
            else
                counter.Add(number, 1);

        foreach (var element in counter) Console.WriteLine($"{element.Key} -> {element.Value}");
    }
}