using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHouse;

internal class SmartSprinkler : SmartDevice, IStatusProvider
{
    public SmartSprinkler(string name) : base(name)
    {
    }

    public void ShowStatus()
    {
        Console.WriteLine($"{Name}: {(IsOn ? "Watering" : "Stopped")}");
    }
}