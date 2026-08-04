using System;
using System.Collections.Generic;
using System.Text;

namespace OCPGood;

internal class TermometerCalibrator : IMaintenance
{
    public void RunMaintenance()
    {
        Console.WriteLine("Calibrating the thermometer...");
    }
}
