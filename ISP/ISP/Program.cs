namespace ISPBad;

internal class Program
{
    static void Main(string[] args)
    {
        var workers = new List<IEmployee>
        {
            new Manager(),
            new OfficeWorker(),
            new RemoteWorker(),
            new SecurityWorker()
        };

        foreach(var worker in workers)
        {
            worker.StartWork();
            worker.EndWork();
            worker.RequestVocation();
            worker.ApproveVocation();
        }

        var office = new Office();

        //office.OpenOffice(workers);

        office.AllowEntry(new RemoteWorker());

        Console.WriteLine(office.enteredEmployeesCount);
    }
}
