namespace OCPBad;

internal class Program
{
    static void Main(string[] args)
    {
        var camera = new ClimateCamera();

        camera.RunMaintenance(MaintenanceType.PipesCleaning);
        camera.RunMaintenance(MaintenanceType.FilterCleaning);
    }
}