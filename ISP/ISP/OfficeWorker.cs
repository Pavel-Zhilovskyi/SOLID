using System;
using System.Collections.Generic;
using System.Text;

namespace ISPBad;

internal class OfficeWorker : IEmployee
{
    public void StartWork()
    {
        Console.WriteLine("Office worker started work.");
    }
    public void EndWork()
    {
        Console.WriteLine("Office worker ended work.");
    }
    public void RequestVocation()
    {
        Console.WriteLine("Office worker requested vacation.");
    }
    public void ApproveVocation()
    {
        
    }
    public void AccessOffice()
    {
        Console.WriteLine("Office worker accessed the office.");
    }
    public void LogWorkingHours()
    {
        
    }
    public void GeneratePayroll()
    {
       
    }
}