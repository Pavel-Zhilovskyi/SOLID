using System;
using System.Collections.Generic;
using System.Text;

namespace ISPGood;

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
}
