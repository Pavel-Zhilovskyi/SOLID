namespace SRPBad;

internal class Program
{
    static void Main(string[] args)
    {
        var article = new Article("My Article", "This is the content of my article.");
        var publisher = new ArticlePublisher(article);
        publisher.Publish();
    }
}