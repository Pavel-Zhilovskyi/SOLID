using System;
using System.Collections.Generic;
using System.Text;

namespace ISPGood;

internal class OfficeWorker : IEmployee, IOfficeAccess
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
    public void AccessOffice()
    {
        Console.WriteLine("Office worker accessed the office.");
    }
}