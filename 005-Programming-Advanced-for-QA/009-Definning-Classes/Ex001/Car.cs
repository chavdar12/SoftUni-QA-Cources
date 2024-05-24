namespace Ex001;

public class Car
{
    private string _make;
    private string _model;
    private int _year;
    private double _fuelQuantity;
    private double _fuelConsumption;
    private Engine _engine;
    private Tire[] _tires;

    public string Make
    {
        get => _make;
        set => _make = value;
    }

    public string Model
    {
        get => _model;
        set => _model = value;
    }

    public int Year
    {
        get => _year;
        set => _year = value;
    }

    public double FuelQuantity
    {
        get => _fuelQuantity;
        set => _fuelQuantity = value;
    }

    public double FuelConsumption
    {
        get => _fuelConsumption;
        set => _fuelConsumption = value;
    }

    public Engine Engine
    {
        get => _engine;
        set => _engine = value;
    }

    public Tire[] Tires
    {
        get => _tires;
        set => _tires = value;
    }

    public Car()
    {
        Make = "VW";
        Model = "Golf";
        Year = 2025;
        FuelQuantity = 200;
        FuelConsumption = 10;
    }

    public Car(string make, string model, int year) : this()
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model,
        year)
    {
        FuelQuantity = fuelQuantity;
        FuelConsumption = fuelConsumption;
    }

    public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine,
        Tire[] tires) : this(make, model, year, fuelQuantity, fuelConsumption)
    {
        Engine = engine;
        Tires = tires;
    }

    public void Drive(double distance)
    {
        if (FuelQuantity - distance * FuelConsumption > 0)
            FuelQuantity -= distance * FuelConsumption;
        else
            Console.WriteLine("Not enough fuel to perform this trip!");
    }

    public string WhoAmI()
    {
        return $"Make: {Make}{Environment.NewLine}" +
               $"Model: {Model}{Environment.NewLine}" +
               $"Year: {Year}{Environment.NewLine}" +
               $"Fuel: {_fuelQuantity:F2}";
    }
}