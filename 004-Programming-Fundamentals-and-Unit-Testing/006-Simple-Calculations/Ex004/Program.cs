namespace Ex004;

internal class Program
{
    private static void Main(string[] args)
    {
        var bathWidth = double.Parse(Console.ReadLine());
        var bathHeight = double.Parse(Console.ReadLine());
        var tileWidth = double.Parse(Console.ReadLine());
        var tileHeight = double.Parse(Console.ReadLine());

        var bathroomArea = bathWidth * bathHeight;
        var bathroomAreaWithSurplus = bathroomArea + bathroomArea * 0.10;
        var tileArea = tileWidth * tileHeight;
        var tilesNeeded = bathroomAreaWithSurplus / tileArea;

        Console.WriteLine(Math.Round(tilesNeeded));
    }
}