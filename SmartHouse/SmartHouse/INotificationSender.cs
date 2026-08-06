using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHouse;

internal interface INotificationSender
{
    void SendNotification(string message);
}
