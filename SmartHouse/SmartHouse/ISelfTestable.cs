using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHouse;

internal interface ISelfTestable
{
    DiagnosticResult RunSelfTest();
}
