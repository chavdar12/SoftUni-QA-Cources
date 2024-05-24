using TestApp;

namespace Ex006;

public class Tests
{
    private Student _student;

    [SetUp]
    public void SetUp()
    {
        _student = new Student();
    }

    [Test]
    public void Test_AddAndGetByCity_ReturnsStudentsInCity_WhenCityExists()
    {
        // Arrange
        string[] students = { "John Doe 25 Sofia", "Jane Smith 22 Varna", "Alice Johnson 20 Sofia" };
        var wantedTown = "Sofia";
        var expected = $"John Doe is 25 years old.{Environment.NewLine}Alice Johnson is 20 years old.";

        // Act
        var actual = _student.AddAndGetByCity(students, wantedTown);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddAndGetByCity_ReturnsEmptyString_WhenCityDoesNotExist()
    {
        // Arrange
        string[] students = { "John Doe 25 Sofia", "Jane Smith 22 Varna", "Alice Johnson 20 Sofia" };
        var wantedTown = "Plovdiv";

        // Act
        var actual = _student.AddAndGetByCity(students, wantedTown);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_AddAndGetByCity_ReturnsEmptyString_WhenNoStudentsGiven()
    {
        // Arrange
        string[] students = Array.Empty<string>();
        var wantedTown = "Sofia";

        // Act
        var actual = _student.AddAndGetByCity(students, wantedTown);

        // Assert
        Assert.That(actual, Is.Empty);
    }
}