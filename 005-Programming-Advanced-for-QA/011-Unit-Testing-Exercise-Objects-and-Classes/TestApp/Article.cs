using System.Text;

namespace TestApp;

public class Article
{
    public string Title { get; set; } = null!;

    public string Content { get; set; } = null!;

    public string Author { get; set; } = null!;

    public List<Article> ArticleList { get; set; } = new();

    public Article AddArticles(string[] articles)
    {
        Article article = new();
        foreach (var data in articles)
        {
            var split = data.Split();

            var title = split[0];
            var content = split[1];
            var author = split[2];

            article.ArticleList.Add(new Article
            {
                Title = title,
                Content = content,
                Author = author
            });
        }

        return article;
    }

    public string GetArticleList(Article article, string printCriteria)
    {
        IOrderedEnumerable<Article>? list = null;
        switch (printCriteria)
        {
            case "title":
                list = article.ArticleList.OrderBy(a => a.Title);
                break;
            case "content":
                list = article.ArticleList.OrderBy(a => a.Content);
                break;
            case "author":
                list = article.ArticleList.OrderBy(a => a.Author);
                break;
            default:
                return string.Empty;
        }

        StringBuilder sb = new();
        foreach (var item in list) sb.AppendLine($"{item.Title} - {item.Content}: {item.Author}");

        return sb.ToString().Trim();
    }
}