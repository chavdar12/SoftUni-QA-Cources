using TestApp;

namespace Ex008;

public class Tests
{
    [Test]
    public void Test_Match_ValidDate_ReturnsExpectedResult()
    {
        // Arrange
        var input = "31-Dec-2022";
        var expected = "Day: 31, Month: Dec, Year: 2022";

        // Act
        var result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }


    // TODO: finish the test
    [Test]
    public void Test_Match_NoMatch_ReturnsEmptyString()
    {
        // Arrange
        var input = "Invalid date format";
        var expected = string.Empty;

        // Act
        var result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_MultipleMatches_ReturnsFirstMatch()
    {
        // Arrange
        var input = "31-Dec-2022, 01-Jan-2023";
        var expected = "Day: 31, Month: Dec, Year: 2022";

        // Act
        var result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        var input = string.Empty;
        var expected = string.Empty;

        // Act
        var result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_NullInput_ThrowsArgumentException()
    {
        // Arrange
        string input = null;

        // Act & Assert
        Assert.That(() => MatchDates.Match(input),
            Throws.ArgumentException.With.Message.EqualTo("Input cannot be null!"));
    }
}