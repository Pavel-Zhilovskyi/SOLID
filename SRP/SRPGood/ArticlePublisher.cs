namespace SRPGood;

internal class ArticlePublisher
{
    private readonly IArticleValidator validator;
    private readonly IArticleFormater formater;
    private readonly IArticleLogger logger;
    private readonly IArticleNotificator notificator;

    public ArticlePublisher(IArticleValidator validator, IArticleFormater formater, IArticleLogger logger, IArticleNotificator notificator   )
    {
        this.validator = validator;
        this.formater = formater;
        this.logger = logger;
        this.notificator = notificator;
    }

    public void Publish(Article article)
    {
        validator.ValidateArticle(article);
        formater.FormatArticle(article);
        PublishArticle(article);
        logger.WriteLog(article);
        notificator.SendNotification(article);
    }

    private void PublishArticle(Article article)
    {
        Console.WriteLine($"Publishing article: {article.Title}");
    }
}