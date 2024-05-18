namespace Ex009;

internal class Program
{
    private static void Main(string[] args)
    {
        var figureType = Console.ReadLine();

        switch (figureType)
        {
            case "square":
            {
                var sideA = double.Parse(Console.ReadLine());
                var area = sideA * sideA;
                Console.WriteLine($"{area:F2}");
                break;
            }
            case "rectangle":
            {
                var sideA = double.Parse(Console.ReadLine());
                var sideB = double.Parse(Console.ReadLine());
                var area = sideA * sideB;
                Console.WriteLine($"{area:F2}");
                break;
            }
            case "circle":
            {
                var radius = double.Parse(Console.ReadLine());
                var area = Math.PI * radius * radius;
                Console.WriteLine($"{area:F2}");
                break;
            }
        }
    }
}