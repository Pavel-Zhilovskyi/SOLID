using System;
using System.Collections.Generic;
using System.Text;

namespace OCPGood
{
    internal class FilterCleaner : IMaintenance
    {
        public void RunMaintenance()
        {
            Console.WriteLine("Cleaning the filter...");
        }
    }
}
