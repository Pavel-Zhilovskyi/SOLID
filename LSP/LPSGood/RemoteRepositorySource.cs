namespace LSPGood;

internal class RemoteRepositorySource : BackupSource
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

    public override DatabaseBackupFile GetBackup()
    {
        return new DatabaseBackupFile("Резервная копия базы данных", "MyDatabase");
    }
}