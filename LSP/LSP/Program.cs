namespace LSPBad;

internal class Program
{
    static void Backup(BackupSource source)
    {
        source.GetFiles();
        int size = source.GetSize();
        Console.WriteLine($"Размер источника: {size} МБ");
        source.DeleteSource();
    }

    static void Main(string[] args)
    {
        var usb = new UsbBackupSource();
        var folder = new FolderBackupSource();

        //Backup(folder);
        //Backup(usb);

        var sources = new List<BackupSource> { usb, folder };
        
        foreach(var source in sources)
        {
            Backup(source);
        }
    }
}