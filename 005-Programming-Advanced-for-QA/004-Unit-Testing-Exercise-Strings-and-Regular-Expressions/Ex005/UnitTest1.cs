using TestApp;

namespace Ex005;

public class Tests
{
    [Test]
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult()
    {
        // Arrange
        var input = "abc";
        var repetitionFactor = 3;
        var expected = "aBcaBcaBc";

        // Act
        var result = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException()
    {
        // Arrange
        var input = "";
        var repetitionFactor = 3;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => { Pattern.GeneratePatternedString(input, repetitionFactor); });
    }

    [Test]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        var input = "abc";
        var repetitionFactor = -3;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => { Pattern.GeneratePatternedString(input, repetitionFactor); });
    }

    [Test]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        var input = "abc";
        var repetitionFactor = 0;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => { Pattern.GeneratePatternedString(input, repetitionFactor); });
    }
}