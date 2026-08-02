using System;
using System.Collections.Generic;
using System.Text;

namespace ISPBad;

internal class RemoteWorker : IEmployee
{
    public void StartWork()
    {
        Console.WriteLine("Online worker started work.");
    }
    public void EndWork()
    {
        Console.WriteLine("Online worker ended work.");
    }
    public void RequestVocation()
    {
        Console.WriteLine("Online worker requested vacation.");
    }
    public void ApproveVocation()
    {
        
    }
    public void AccessOffice()
    {
        
    }
    public void LogWorkingHours()
    {
        
    }
    public void GeneratePayroll()
    {
        
    }
}
