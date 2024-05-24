namespace Ex004;

internal class Truck
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Weight { get; set; }

    public Truck()
    {
    }

    public Truck(string brand, string model, string weight)
    {
        Brand = brand;
        Model = model;
        Weight = weight;
    }
}

internal class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string HorsePower { get; set; }

    public Car()
    {
    }

    public Car(string brand, string model, string horsePower)
    {
        Brand = brand;
        Model = model;
        HorsePower = horsePower;
    }
}

internal class Catalog
{
    public List<Car> CarList { get; set; }
    public List<Truck> TruckList { get; set; }

    public Catalog()
    {
        CarList = new List<Car>();
        TruckList = new List<Truck>();
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        var input = Console.ReadLine();

        var catalog = new Catalog();

        while (input != "end")
        {
            var info = input.Split("/").ToArray();
            var vehicleType = info[0];
            var brand = info[1];
            var model = info[2];

            if (vehicleType == "Car")
            {
                var horsePower = info[3];
                var car = new Car(brand, model, horsePower);
                catalog.CarList.Add(car);
            }
            else if (vehicleType == "Truck")
            {
                var weigth = info[3];
                var truck = new Truck(brand, model, weigth);
                catalog.TruckList.Add(truck);
            }

            input = Console.ReadLine();
        }

        if (catalog.CarList.Count != 0)
        {
            Console.WriteLine("Cars:");
            catalog.CarList
                .OrderBy(c => c.Brand)
                .Select(c =>
                {
                    Console.WriteLine($"{c.Brand}: {c.Model} - {c.HorsePower}hp");

                    return 1;
                })
                .ToList();
        }

        if (catalog.TruckList.Count != 0)
        {
            Console.WriteLine("Trucks:");
            catalog.TruckList
                .OrderBy(t => t.Brand)
                .Select(t =>
                {
                    Console.WriteLine($"{t.Brand}: {t.Model} - {t.Weight}kg");

                    return 1;
                })
                .ToList();
        }
    }
}