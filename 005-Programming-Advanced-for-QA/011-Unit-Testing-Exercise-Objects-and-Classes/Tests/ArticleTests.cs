using TestApp;

namespace Tests;

public class ArticleTests
{
    private Article _article;

    [SetUp]
    public void SetUp()
    {
        _article = new Article();
    }

    [Test]
    public void Test_AddArticles_ReturnsArticleWithCorrectData()
    {
        // Arrange
        string[] articles = { "Title1 Content1 Author1", "Title2 Content2 Author2", "Title3 Content3 Author3" };
        List<Article> expectedArticleList = new()
        {
            new Article
            {
                Title = "Title1",
                Content = "Content1",
                Author = "Author1"
            },
            new Article
            {
                Title = "Title2",
                Content = "Content2",
                Author = "Author2"
            },
            new Article
            {
                Title = "Title3",
                Content = "Content3",
                Author = "Author3"
            }
        };

        // Act
        var actual = _article.AddArticles(articles);

        // Assert
        Assert.That(actual.ArticleList, Has.Count.EqualTo(3));
        for (var i = 0; i < actual.ArticleList.Count; i++)
        {
            Assert.That(actual.ArticleList[i].Title, Is.EqualTo(expectedArticleList[i].Title));
            Assert.That(actual.ArticleList[i].Content, Is.EqualTo(expectedArticleList[i].Content));
            Assert.That(actual.ArticleList[i].Author, Is.EqualTo(expectedArticleList[i].Author));
        }
    }

    [Test]
    public void Test_GetArticleList_SortsArticlesByTitle()
    {
        // Arrange
        var article = new Article()
        {
            ArticleList = new List<Article>
            {
                new()
                {
                    Title = "ATitle",
                    Content = "ContentA",
                    Author = "AuthorA"
                },
                new()
                {
                    Title = "BTitle",
                    Content = "ContentB",
                    Author = "AuthorB"
                },
                new()
                {
                    Title = "CTitle",
                    Content = "ContentC",
                    Author = "AuthorC"
                }
            }
        };
        var printCriteria = "title";
        var expected = $"ATitle - ContentA: AuthorA{Environment.NewLine}" +
                       $"BTitle - ContentB: AuthorB{Environment.NewLine}" +
                       $"CTitle - ContentC: AuthorC";

        // Act
        var actual = _article.GetArticleList(article, printCriteria);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetArticleList_ReturnsEmptyString_WhenInvalidPrintCriteria()
    {
        // Arrange
        var article = new Article()
        {
            ArticleList = new List<Article>
            {
                new()
                {
                    Title = "ATitle",
                    Content = "ContentA",
                    Author = "AuthorA"
                },
                new()
                {
                    Title = "BTitle",
                    Content = "ContentB",
                    Author = "AuthorB"
                },
                new()
                {
                    Title = "CTitle",
                    Content = "ContentC",
                    Author = "AuthorC"
                }
            }
        };
        var printCriteria = "else";

        // Act
        var actual = _article.GetArticleList(article, printCriteria);

        // Assert
        Assert.That(actual, Is.Empty);
    }
}