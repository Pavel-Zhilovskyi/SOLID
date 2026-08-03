using System;
using System.Collections.Generic;
using System.Text;

namespace LSPGood;

internal class RemoteRepositorySource : BackupSource, IDeletableSource
{
    public override void ReadFiles()
    {
        Console.WriteLine("Получение файлов из репозитория.");
    }
    public override int GetSize()
    {
        Console.WriteLine("Расчет размера репозитория.");
        return 2048;
    }
    public void DeleteSource()
    {
        Console.WriteLine("Удаление репозитория.");
    }
}