using TestApp;

namespace Ex004;

public class Tests
{
    // TODO: finish the test
    [Test]
    public void Test_ReverseAndConcatenateStrings_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string[] input = { };

        // Act
        var result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.AreEqual(string.Empty, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_ReverseAndConcatenateStrings_SingleString_ReturnsSameString()
    {
        // Arrange
        string[] input = { "Hello" };

        // Act
        var result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.AreEqual("Hello", result);
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_MultipleStrings_ReturnsReversedConcatenatedString()
    {
        // Arrange
        string[] input = { "Hello", "World", "!" };

        // Act
        var result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.AreEqual("!WorldHello", result);
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_NullInput_ReturnsEmptyString()
    {
        // Arrange
        string[] input = null;

        // Act
        var result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.AreEqual(string.Empty, result);
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_WhitespaceInput_ReturnsConcatenatedString()
    {
        // Arrange
        string[] inputStrings = { "Hello", "  ", "World" };
        var expected = "World  Hello";

        // Act
        var result = ReverseConcatenate.ReverseAndConcatenateStrings(inputStrings);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_LargeInput_ReturnsReversedConcatenatedString()
    {
        // Arrange
        string[] input = Enumerable.Range(1, 10000).Select(i => i.ToString()).ToArray();

        // Act
        var result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Arrange
        var expected = string.Join("", Enumerable.Range(1, 10000).Select(i => i.ToString()).Reverse());

        // Assert
        Assert.AreEqual(expected, result);
    }
}