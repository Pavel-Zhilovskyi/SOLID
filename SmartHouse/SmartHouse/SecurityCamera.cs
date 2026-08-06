using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHouse;

internal class SecurityCamera : SmartDevice, IStatusProvider, ISelfTestable,
    ISoftwareUpdatable, INotificationSender
{
    public SecurityCamera(string name) : base(name)
    {
    }

    public void ShowStatus()
    {
        Console.WriteLine($"{Name}: {(IsOn ? "On" : "Off")}");
    }

    public DiagnosticResult RunSelfTest()
    {
        return new DiagnosticResult(true, "Camera");
    }

    public void UpdateSoftware()
    {
        Console.WriteLine($"{Name}: Firmware updated.");
    }

    public void SendNotification(string message)
    {
        Console.WriteLine($"{Name}: {message}");
    }
}