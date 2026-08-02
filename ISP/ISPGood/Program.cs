namespace ISPGood;

internal class Program
{
    static void Main(string[] args)
    {
        var offlineWorkers = new List<IOfficeAccess>
        {
            new SecurityWorker(),
            new OfficeWorker(),
            new Manager()
        };

        foreach(var offlineWorker in offlineWorkers)
        {
            offlineWorker.AccessOffice();
        }

       //new RemoteWorker().AccessOffice();//impossible
    }
}
