using System;
using System.Collections.Generic;
using System.Text;

namespace OCPGood
{
    internal class PipesCleaner : IMaintenance
    {
        public void RunMaintenance()
        {
            Console.WriteLine("Cleaning the pipes...");
        }
    }
}