namespace Ex003;

internal class Program
{
    private static void Main(string[] args)
    {
        var input = Console.ReadLine();

        var products = new Dictionary<string, List<double>>();

        while (input != "buy")
        {
            string[] inputArray = input.Split();
            var product = inputArray[0];
            var price = double.Parse(inputArray[1]);
            var quantity = double.Parse(inputArray[2]);

            if (!products.ContainsKey(product))
            {
                products.Add(product, new List<double>());
                products[product].Add(price);
                products[product].Add(quantity);
            }
            else
            {
                products[product][0] = price;
                products[product][1] += quantity;
            }

            input = Console.ReadLine();
        }

        foreach (var pair in products)
        {
            var product = pair.Key;
            var price = pair.Value[0];
            var quantity = pair.Value[1];
            var amount = price * quantity;
            Console.WriteLine($"{product} -> {amount:F2}");
        }
    }
}