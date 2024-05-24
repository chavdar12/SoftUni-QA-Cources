using System.Collections.Generic;

namespace TestApp.Vehicle;

public class Catalogue
{
    public Catalogue()
    {
        TruckList = new List<Truck>();
        CarList = new List<Car>();
    }

    public List<Truck> TruckList { get; set; }

    public List<Car> CarList { get; set; }
}