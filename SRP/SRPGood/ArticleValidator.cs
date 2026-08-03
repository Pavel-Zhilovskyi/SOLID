namespace SRPGood;

internal class ArticleValidator : IArticleValidator
{
    public void ValidateArticle(Article article)
    {
        Console.WriteLine($"Validating article: {article.Title}");
    }
}