using System.Text;

namespace TestApp.Store;

public class Shop
{
    public string AddAndGetBoxes(string[] products)
    {
        List<Box> boxList = new();
        foreach (var product in products)
        {
            var data = product.Split();

            var serialNumber = long.Parse(data[0]);
            var name = data[1];
            var itemQty = int.Parse(data[2]);
            var price = decimal.Parse(data[3]);

            var boxPrice = price * itemQty;
            Item newItem = new()
            {
                Name = name,
                Price = price
            };

            Box newBox = new()
            {
                SerialNumber = serialNumber,
                Item = newItem,
                ItemQuantity = itemQty,
                BoxPrice = boxPrice
            };

            boxList.Add(newBox);
        }

        StringBuilder sb = new();
        foreach (var box in boxList.OrderByDescending(box => box.BoxPrice))
        {
            sb.AppendLine(box.SerialNumber.ToString());
            sb.AppendLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
            sb.AppendLine($"-- ${box.BoxPrice:f2}");
        }

        return sb.ToString().Trim();
    }
}