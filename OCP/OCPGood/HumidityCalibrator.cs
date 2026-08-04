using System;
using System.Collections.Generic;
using System.Text;

namespace OCPGood;

internal class HumidityCalibrator : IMaintenance
{
    public void RunMaintenance()
    {
        Console.WriteLine("Calibrating the humidity sensor...");
    }
}