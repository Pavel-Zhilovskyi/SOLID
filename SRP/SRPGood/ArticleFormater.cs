namespace SRPGood;

internal class ArticleFormater : IArticleFormater
{
    public void FormatArticle(Article article)
    {
        Console.WriteLine($"Formatting article: {article.Title}");
    }
}