using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHouse;

internal class DiagnosticResult
{
    public bool Success { get; }
    public string Message { get; }

    public DiagnosticResult(bool success, string message)
    {
        Success = success;
        Message = message;
    }
}