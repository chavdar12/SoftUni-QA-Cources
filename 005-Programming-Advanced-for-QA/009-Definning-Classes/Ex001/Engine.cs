namespace Ex001;

public class Engine
{
    private int _horsePower;
    private double _cubicCapacity;

    public int HorsePower
    {
        get => _horsePower;
        set => _horsePower = value;
    }

    public double CubicCapacity
    {
        get => _cubicCapacity;
        set => _cubicCapacity = value;
    }

    public Engine()
    {
    }

    public Engine(int horsePower, double cubicCapacity)
    {
        HorsePower = horsePower;
        CubicCapacity = cubicCapacity;
    }
}