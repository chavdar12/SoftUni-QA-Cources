namespace Ex002;

internal class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        List<string> products = [];

        for (var i = 0; i < n; i++)
        {
            var product = Console.ReadLine();
            products.Add(product);
        }

        products.Sort();

        for (var i = 0; i < products.Count; i++)
            Console.WriteLine($"{i + 1}.{products[i]}");
    }
}