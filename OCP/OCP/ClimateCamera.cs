namespace OCPBad;

internal class ClimateCamera
{       
    public void RunMaintenance(MaintenanceType maintenanceType)
    {
        switch (maintenanceType)
        {
            case MaintenanceType.FilterCleaning:
                Console.WriteLine("Cleaning the filter...");
                break;
            
            case MaintenanceType.PipesCleaning:
                Console.WriteLine("Cleaning the pipes...");
                break;
            
            case MaintenanceType.BodyCleaning:
                Console.WriteLine("Cleaning the body...");
                break;
            
            case MaintenanceType.TermometerCalibration:
                Console.WriteLine("Calibrating the thermometer...");
                break;
            
            case MaintenanceType.HumiditySensorCalibration:
                Console.WriteLine("Calibrating the humidity sensor...");
                break;
            
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}