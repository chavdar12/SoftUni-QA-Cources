namespace Ex002;

internal class Program
{
    private static void Main(string[] args)
    {
        var resource = Console.ReadLine();

        Dictionary<string, int> resources = new();

        while (resource != "stop")
        {
            var quantity = int.Parse(Console.ReadLine());

            if (resources.ContainsKey(resource))
                resources[resource] += quantity;
            else
                resources.Add(resource, quantity);
            resource = Console.ReadLine();
        }

        foreach (var pair in resources) Console.WriteLine($"{pair.Key} -> {pair.Value}");
    }
}