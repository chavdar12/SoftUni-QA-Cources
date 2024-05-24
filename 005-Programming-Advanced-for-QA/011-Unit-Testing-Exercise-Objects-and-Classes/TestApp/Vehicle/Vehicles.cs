using System.Text;

namespace TestApp.Vehicle;

public class Vehicles
{
    public string AddAndGetCatalogue(string[] vehicles)
    {
        Catalogue catalogue = new();
        foreach (var vehicle in vehicles)
        {
            var data = vehicle.Split("/");

            var type = data[0];
            var brand = data[1];
            var model = data[2];
            var power = int.Parse(data[3]);

            if (type == "Truck")
                catalogue.TruckList.Add(new Truck
                {
                    Brand = brand,
                    Model = model,
                    Weight = power
                });
            else
                catalogue.CarList.Add(new Car
                {
                    Brand = brand,
                    Model = model,
                    HorsePower = power
                });
        }

        StringBuilder sb = new();
        sb.AppendLine("Cars:");
        foreach (var car in catalogue.CarList.OrderBy(car => car.Brand))
            sb.AppendLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");

        sb.AppendLine("Trucks:");
        foreach (var truck in catalogue.TruckList.OrderBy(truck => truck.Brand))
            sb.AppendLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");

        return sb.ToString().Trim();
    }
}