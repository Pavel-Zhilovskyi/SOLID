using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHouse;

internal class Thermostat : SmartDevice,
    IStatusProvider,
    ISelfTestable
{
    public Thermostat(string name) : base(name)
    {
    }

    public void ShowStatus()
    {
        Console.WriteLine($"{Name}: {(IsOn ? "On" : "Off")}");
    }

    public DiagnosticResult RunSelfTest()
    {
        return new DiagnosticResult(true, "Temperature sensor");
    }
}