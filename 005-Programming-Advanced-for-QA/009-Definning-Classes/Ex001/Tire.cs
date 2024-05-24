namespace Ex001;

public class Tire
{
    private int _year;
    private double _pressure;

    public int Year
    {
        get => _year;
        set => _year = value;
    }

    public double Pressure
    {
        get => _pressure;
        set => _pressure = value;
    }

    public Tire()
    {
    }

    public Tire(int year, double pressure)
    {
        Year = year;
        Pressure = pressure;
    }
}