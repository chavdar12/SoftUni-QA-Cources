namespace Ex001;

internal class Program
{
    private static void Main(string[] args)
    {
        var tires = new Tire[]
        {
            new(1, 2.5),
            new(1, 2.1),
            new(2, 0.5),
            new(2, 2.3)
        };

        var engine = new Engine(560, 6300);

        var car = new Car("Lamborghini", "Urus", 2010, 250, 9, engine, tires);

        car.Drive(100);
        car.Drive(50);
        car.Drive(200);

        Console.WriteLine(car.FuelQuantity);
    }
}