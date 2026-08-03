namespace LSPGood;

internal abstract class BackupSource
{
    public abstract void ReadFiles();
    public abstract int GetSize();
}
