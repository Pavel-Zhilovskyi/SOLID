namespace LSPGood;

internal class DatabaseBackupFile : BackupFile
{
    public string DatabaseName { get; }

    public DatabaseBackupFile(string name, string databaseName)
        : base(name)
    {
        DatabaseName = databaseName;
    }
}