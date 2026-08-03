using System;
using System.Collections.Generic;
using System.Text;

namespace LSPBad;

internal class FolderBackupSource : BackupSource
{
    public override void GetFiles()
    {
        Console.WriteLine("Получение файлов из папки.");
    }
    public override int GetSize()
    {
        Console.WriteLine("Расчет размера папки.");
        return 512;
    }
    public override void DeleteSource()
    {
        Console.WriteLine("Удаление папки.");
    }
}
