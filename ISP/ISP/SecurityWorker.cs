namespace ISPBad;

internal class SecurityWorker : IEmployee
{
    public void StartWork()
    {
        Console.WriteLine("Security started work.");
    }
    public void EndWork()
    {
        Console.WriteLine("Security ended work.");
    }
    public void RequestVocation()
    {
        Console.WriteLine("Security requested vacation.");
    }
    public void ApproveVocation()
    {
        
    }
    public void AccessOffice()
    {
        Console.WriteLine("Security accessed the office.");
    }
    public void LogWorkingHours()
    {
        Console.WriteLine("Security logged working hours.");
    }
    public void GeneratePayroll()
    {
        
    }
}
