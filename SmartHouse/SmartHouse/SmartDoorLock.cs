using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHouse;

internal class SmartDoorLock : SmartDevice, IStatusProvider, ISoftwareUpdatable,
    INotificationSender
{
    public SmartDoorLock(string name) : base(name)
    {
    }

    public void ShowStatus()
    {
        Console.WriteLine($"{Name}: Locked");
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