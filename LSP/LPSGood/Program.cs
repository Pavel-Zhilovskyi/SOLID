namespace LSPGood;

internal class Program
{
    static void Main(string[] args)
    {
        var folder = new FolderBackupSource();
        var usb = new UsbBackupSource();
        var repo = new RemoteRepositorySource();

        var sources = new List<BackupSource>
        {
            folder,
            usb,
            repo
        };

        var deletableSources = new List<IDeletableSource>
        {
            folder,
            repo
        };

        foreach (var source in sources)
        {
            source.ReadFiles();
            Console.WriteLine($"Size: {source.GetSize()}");
        }

        foreach(var deletableSource in deletableSources)
        {
            deletableSource.DeleteSource();
        }
    }
}