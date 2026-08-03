namespace LSPGood;

internal class FolderBackupSource : BackupSource, IDeletableSource
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
    public void DeleteSource()
    {
        Console.WriteLine("Удаление папки.");
    }
}
