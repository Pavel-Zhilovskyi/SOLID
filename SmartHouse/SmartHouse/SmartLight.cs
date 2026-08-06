using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHouse;

internal class SmartLight : SmartDevice, IStatusProvider
{
    public SmartLight(string name) : base(name)
    {
    }

    public void ShowStatus()
    {
        Console.WriteLine($"{Name}: {(IsOn ? "On" : "Off")}");
    }
}