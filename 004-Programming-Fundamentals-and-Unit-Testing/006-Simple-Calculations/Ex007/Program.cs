namespace Ex007;

internal class Program
{
    private static void Main(string[] args)
    {
        var penPackages = int.Parse(Console.ReadLine());
        var markerPackets = int.Parse(Console.ReadLine());
        var boardCleanerLiters = int.Parse(Console.ReadLine());
        var discountPercentage = int.Parse(Console.ReadLine());

        var pricePen = penPackages * 5.80;
        var priceMarker = markerPackets * 7.20;
        var boardCleanerPrice = boardCleanerLiters * 1.20;
        var priceAllMaterials = pricePen + priceMarker + boardCleanerPrice;
        var discountedPrice = priceAllMaterials - priceAllMaterials * 0.25;

        Console.WriteLine(discountedPrice);
    }
}