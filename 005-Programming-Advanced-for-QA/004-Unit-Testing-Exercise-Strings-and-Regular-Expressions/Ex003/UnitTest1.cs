using TestApp;

namespace Ex003;

public class Tests
{
    // TODO: finish the test
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWords = { };
        var text = "This is a test text.";

        // Act
        var result = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.AreEqual(text, result);
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        // Arrange
        string[] bannedWords = { "test" };
        var text = "This is a test text.";

        // Act
        var result = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.AreEqual("This is a **** text.", result);
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWords = { };
        var text = "This is a test text.";

        // Act
        var result = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.AreEqual(text, result);
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        // Arrange
        string[] bannedWords = { "test", "word" };
        var text = "This is a test word.";

        // Act
        var result = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.AreEqual("This is a **** ****.", result);
    }
}