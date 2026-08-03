namespace SRPGood;

internal class Article
{
    public string Title { get; set; }
    public string Text { get; set; }
    public bool IsPublished { get; set; }

    public Article(string title, string text)
    {
        Title = title;
        Text = text;
        IsPublished = false;
    }
}