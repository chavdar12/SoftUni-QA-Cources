using TestApp.Vehicle;

namespace Ex007;

public class Tests
{
    private Vehicles _vehicles;

    [SetUp]
    public void SetUp()
    {
        _vehicles = new Vehicles();
    }

    [Test]
    public void Test_AddAndGetCatalogue_ReturnsSortedCatalogue()
    {
        // Arrange
        string[] vehicles = { "Car/Ford/Focus/120", "Car/Toyota/Camry/150", "Truck/Volvo/VNL/500" };
        var expected = $"Cars:{Environment.NewLine}" +
                       $"Ford: Focus - 120hp{Environment.NewLine}" +
                       $"Toyota: Camry - 150hp{Environment.NewLine}" +
                       $"Trucks:{Environment.NewLine}" +
                       $"Volvo: VNL - 500kg";

        // Act
        var actual = _vehicles.AddAndGetCatalogue(vehicles);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddAndGetCatalogue_ReturnsEmptyCatalogue_WhenNoDataGiven()
    {
        // Arrange
        var vehicles = Array.Empty<string>();
        var expected = $"Cars:{Environment.NewLine}" + $"Trucks:";

        // Act
        var actual = _vehicles.AddAndGetCatalogue(vehicles);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}