using System;
using System.Collections.Generic;
using System.Text;

namespace LSPBad;

internal class UsbBackupSource : BackupSource
{
    public override void GetFiles()
    {
        Console.WriteLine("Получение файлов с USB накопителя.");
    }

    public override int GetSize()
    {
        Console.WriteLine("Расчет размера USB накопителя.");
        return 1024;
    }

    public override void DeleteSource()
    {
        //компания запретила удаление содержимого с USB накопителя
    }
}