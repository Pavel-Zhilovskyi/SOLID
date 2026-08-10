namespace LSPGood;

internal class FolderBackupSource : BackupSource
{
    public override void ReadFiles()
    {
        Console.WriteLine("Получение файлов из папки.");
    }

    public override int GetSize()
    {
        Console.WriteLine("Расчет размера папки.");
        return 512;
    }
}