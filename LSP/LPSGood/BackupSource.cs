namespace LSPGood;

internal class BackupSource
{
    public virtual void ReadFiles()
    {
        Console.WriteLine("Получение файлов из источника.");
    }

    public virtual int GetSize()
    {
        Console.WriteLine("Расчет размера источника.");
        return 0;
    }

    public virtual BackupFile GetBackup()
    {
        return new BackupFile("Обычная резервная копия");
    }
}