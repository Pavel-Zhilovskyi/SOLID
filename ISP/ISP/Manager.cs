using System;
using System.Collections.Generic;
using System.Text;

namespace ISPBad;

internal class Manager : IEmployee
{
    public void StartWork()
    {
        Console.WriteLine("Manager started work.");
    }
    public void EndWork()
    {
        Console.WriteLine("Manager ended work.");
    }
    public void RequestVocation()
    {
        Console.WriteLine("Manager requested vacation.");
    }
    public void ApproveVocation()
    {
        Console.WriteLine("Manager approved vacation.");
    }
    public void AccessOffice()
    {
        Console.WriteLine("Manager accessed the office.");
    }
    public void LogWorkingHours()
    {
        
    }
    public void GeneratePayroll()
    {
        Console.WriteLine("Manager generated payroll.");
    }
}
