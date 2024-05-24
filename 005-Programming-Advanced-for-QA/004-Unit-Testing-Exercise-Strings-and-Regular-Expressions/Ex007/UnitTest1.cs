using TestApp;

namespace Ex007;

public class Tests
{
    [Test]
    public void Test_Match_ValidPhoneNumbers_ReturnsMatchedNumbers()
    {
        // Arrange
        var phoneNumbers = "+359-2-124-5678, +359 2 986 5432, +359-2-555-5555";
        var expected = "+359-2-124-5678, +359 2 986 5432, +359-2-555-5555";

        // Act
        var result = MatchPhoneNumbers.Match(phoneNumbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_NoValidPhoneNumbers_ReturnsEmptyString()
    {
        // Arrange
        var phoneNumbers = "Invalid numbers: 123, 456-789";

        // Act
        var result = MatchPhoneNumbers.Match(phoneNumbers);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_Match_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        var phoneNumbers = "";
        var expected = "";

        // Act
        var result = MatchPhoneNumbers.Match(phoneNumbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_MixedValidAndInvalidNumbers_ReturnsOnlyValidNumbers()
    {
        // Arrange
        var phoneNumbers = "+359-2-124-5678, Invalid: 123456, +359 2 986 5432, Invalid: 456-789, +359-2-555-5555";
        var expected = "+359-2-124-5678, +359 2 986 5432, +359-2-555-5555";

        // Act
        var result = MatchPhoneNumbers.Match(phoneNumbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}