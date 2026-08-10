namespace LSPGood;

internal class Program
{
    static void Main(string[] args)
    {
        var sources = new List<BackupSource>
        {
            new BackupSource(),
            new FolderBackupSource(),
            new UsbBackupSource(),
            new RemoteRepositorySource()
        };

        foreach (var source in sources)
        {
            ProcessBackup(source);
        }
    }

    static void ProcessBackup(BackupSource source)
    {
        source.ReadFiles();

        Console.WriteLine($"Size: {source.GetSize()}");

        BackupFile backup = source.GetBackup();

        Console.WriteLine($"Backup: {backup.Name}");
        Console.WriteLine();
    }
}