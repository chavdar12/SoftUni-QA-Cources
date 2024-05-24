using TestApp;

namespace Ex006;

public class Tests
{
    [Test]
    public void Test_Match_ValidNames_ReturnsMatchedNames()
    {
        // Arrange
        var names = "John Smith and Alice Johnson";
        var expected = "John Smith Alice Johnson";

        // Act
        var result = MatchNames.Match(names);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_NoValidNames_ReturnsEmptyString()
    {
        // Arrange
        var names = "no valid names here";
        var expected = "";

        // Act
        var result = MatchNames.Match(names);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        var names = "";
        var expected = "";

        // Act
        var result = MatchNames.Match(names);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}