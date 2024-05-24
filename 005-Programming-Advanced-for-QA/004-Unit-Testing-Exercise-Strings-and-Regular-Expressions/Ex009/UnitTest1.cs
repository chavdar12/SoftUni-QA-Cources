using TestApp;

namespace Ex009;

public class Tests
{
    [Test]
    public void Test_ExtractUrls_EmptyText_ReturnsEmptyList()
    {
        // Arrange
        var text = "";

        // Act
        var result = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish the test
    [Test]
    public void Test_ExtractUrls_NoUrlsInText_ReturnsEmptyList()
    {
        // Arrange
        var text = "This is a text without any URLs.";

        // Act
        var result = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_ExtractUrls_SingleUrlInText_ReturnsSingleUrl()
    {
        // Arrange
        var text = "Visit our website at https://example.com";

        // Act
        var result = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That(result, Has.Exactly(1).EqualTo("https://example.com"));
    }

    [Test]
    public void Test_ExtractUrls_MultipleUrlsInText_ReturnsAllUrls()
    {
        // Arrange
        var text = "Check out these URLs: https://example.com, http://test.com, https://another-example.com";

        // Act
        var result = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That(result,
            Is.EquivalentTo(
                new List<string> { "https://example.com", "http://test.com", "https://another-example.com" }));
    }

    [Test]
    public void Test_ExtractUrls_UrlsInQuotationMarks_ReturnsUrlsInQuotationMarks()
    {
        // Arrange
        var text = "Here are some URLs in quotation marks: \"https://example.com\", \"http://test.com\"";

        // Act
        var result = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That(result, Is.EquivalentTo(new List<string> { "https://example.com", "http://test.com" }));
    }
}