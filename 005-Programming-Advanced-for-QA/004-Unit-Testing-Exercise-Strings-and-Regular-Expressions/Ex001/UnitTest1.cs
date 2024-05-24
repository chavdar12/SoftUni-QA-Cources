using TestApp;

namespace Ex001;

public class Tests
{
    [Test]
    public void Test_Repeat_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        var input = Array.Empty<string>();

        // Act
        var result = RepeatStrings.Repeat(input);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_Repeat_SingleInputString_ReturnsRepeatedString()
    {
        // Arrange
        string[] input = { "sto" };

        // Act
        var result = RepeatStrings.Repeat(input);

        // Assert
        var expectedResult = "stostosto";
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Repeat_MultipleInputStrings_ReturnsConcatenatedRepeatedStrings()
    {
        // Arrange
        string[] input = { "3412", "AbA" };

        // Act
        var result = RepeatStrings.Repeat(input);

        // Assert
        var expected = "3412341234123412AbAAbAAbA";
        Assert.That(result, Is.EqualTo(expected));
    }
}