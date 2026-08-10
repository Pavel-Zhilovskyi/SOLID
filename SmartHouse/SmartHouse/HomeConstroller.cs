using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHouse;

internal class HomeController
{
    public void ShowStatuses(List<IStatusProvider> devices)
    {
        foreach (var device in devices)
            device.ShowStatus();
    }

    public void RunDiagnostics(List<ISelfTestable> devices)
    {
        foreach (var device in devices)
        {
            DiagnosticResult result = device.RunSelfTest();

            Console.WriteLine($"{result.Message} ({(result.Success ? "OK" : "FAIL")})");
        }
    }

    public void UpdateSoftware(List<ISoftwareUpdatable> devices)
    {
        foreach (var device in devices)
            device.UpdateSoftware();
    }

    public void SendAlert(List<INotificationSender> devices, string message)
    {
        foreach (var device in devices)
            device.SendNotification(message);
    }
}