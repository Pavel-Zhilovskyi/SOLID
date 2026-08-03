using System;
using System.Collections.Generic;
using System.Text;

namespace SRPGood;

internal class Logger : IArticleLogger
{
    public void WriteLog(Article article)
    {
        Console.WriteLine($"Writing log entry for article: {article.Title}");
    }
}