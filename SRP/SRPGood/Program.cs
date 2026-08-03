namespace SRPGood;

internal class Program
{
    static void Main(string[] args)
    {
        var article = new Article("My Article", "This is the content of my article.");
        
        IArticleValidator validator = new ArticleValidator();
        IArticleFormater formater = new ArticleFormater();
        IArticleLogger logger = new Logger();
        IArticleNotificator notificator = new Notificator();

        var publisher = new ArticlePublisher(validator, formater, logger, notificator);
        publisher.Publish(article);
    }
}