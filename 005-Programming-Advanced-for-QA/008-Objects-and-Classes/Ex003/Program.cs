namespace Ex003;

internal class Item
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Item()
    {
    }

    public Item(string name, double price)
    {
        Name = name;
        Price = price;
    }
}

internal class Box
{
    public string SerialNumber { get; set; }
    public Item Item { get; set; }
    public int Quantity { get; set; }
    public double PriceOfABox { get; set; }

    public Box()
    {
    }

    public Box(string serialNumber, Item item, int itemQuantity)
    {
        SerialNumber = serialNumber;
        Item = item;
        Quantity = itemQuantity;
        PriceOfABox = item.Price * itemQuantity;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        var boxes = new List<Box>();

        var input = Console.ReadLine();

        while (input != "end")
        {
            string[] data = input.Split().ToArray();
            var serialNumber = data[0];
            var itemName = data[1];
            var itemQuantity = int.Parse(data[2]);
            var itemPrice = double.Parse(data[3]);

            var item = new Item(itemName, itemPrice);
            var box = new Box(serialNumber, item, itemQuantity);

            boxes.Add(box);

            input = Console.ReadLine();
        }

        boxes.OrderByDescending(b => b.PriceOfABox)
            .Select(b =>
            {
                Console.WriteLine(b.SerialNumber);
                Console.WriteLine($"-- {b.Item.Name} - ${b.Item.Price:F2}: {b.Quantity}");
                Console.WriteLine($"-- ${b.PriceOfABox:F2}");

                return 1;
            })
            .ToList();
    }
}