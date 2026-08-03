using System;
using System.Collections.Generic;
using System.Text;

namespace SRPGood;

internal class Notificator : IArticleNotificator
{
    public void SendNotification(Article article)
    {
        Console.WriteLine($"Sending notification for article: {article.Title}");
    }
}