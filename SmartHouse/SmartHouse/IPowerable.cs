using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHouse;

internal interface IPowerable
{
    void TurnOn();
    void TurnOff();
}