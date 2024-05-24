using TestApp;

namespace Ex002;

public class Tests
{
    // TODO: finish the test
    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromMiddle()
    {
        // Arrange
        var toRemove = "fox";
        var input = "The quick brown fox jumps over the lazy dog";


        // Act
        var result = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        var expected = "The quick brown jumps over the lazy dog";
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromStart()
    {
        // Arrange
        var toRemove = "Hello";
        var input = "Hello, my name is Daniel";


        // Act
        var result = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        var expected = ", my name is Daniel";
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromEnd()
    {
        // Arrange
        var toRemove = "Mercedes";
        var input = "The best car in the world is Mercedes";

        // Act
        var result = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        var expected = "The best car in the world is";
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesAllOccurrences()
    {
        // Arrange
        const string toRemove = "Golf";
        const string input = "First Golf was made in 1976, and the latest version of Golf 8 is from 2024";


        // Act
        var result = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        var expected = "First was made in 1976, and the latest version of 8 is from 2024";
        Assert.That(result, Is.EqualTo(expected));
    }
}