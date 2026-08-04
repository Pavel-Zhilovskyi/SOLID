namespace OCPGood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var camera = new ClimateCamera();
            var bodyCleaner = new BodyCleaner();
            camera.RunMaintenance(bodyCleaner);
            var thermometerCalibrator = new TermometerCalibrator();
            camera.RunMaintenance(thermometerCalibrator);

            var maintenanceTasks = new List<IMaintenance>
            {
                new FilterCleaner(),
                new PipesCleaner(),
                new HumidityCalibrator(),
                new BodyCleaner(),
                new TermometerCalibrator()
            };

            foreach(var task in maintenanceTasks)
            {
                camera.RunMaintenance(task);
            }
        }
    }
}