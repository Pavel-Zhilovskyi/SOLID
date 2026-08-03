namespace SRPBad;

internal class ArticlePublisher
{
    Article article;

    public ArticlePublisher(Article article)
    {
        this.article = article;
    }

    public void Publish()
    {
        ValidateArticle();
        FormatArticle();
        PublishArticle();
        WriteLog();
        SendNotification();
    }

    public void ValidateArticle()
    {
        Console.WriteLine("Validating article...");
    }

    public void FormatArticle()
    {
        Console.WriteLine("Formatting article...");
    }

    public void PublishArticle()
    {
        Console.WriteLine($"Publishing article: {article.Title}");
    }

    public void WriteLog()
    {
        Console.WriteLine("Writing log entry...");
    }

    public void SendNotification()
    {
        Console.WriteLine("Sending notification...");
    }
}