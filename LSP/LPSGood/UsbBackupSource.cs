namespace LSPGood;

internal class UsbBackupSource : BackupSource
{
    public override void ReadFiles()
    {
        Console.WriteLine("Получение файлов с USB накопителя.");
    }

    public override int GetSize()
    {
        Console.WriteLine("Расчет размера USB накопителя.");
        return 1024;
    }
}