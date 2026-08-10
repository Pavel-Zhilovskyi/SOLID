namespace SmartHouse;

internal class Program
{
    static void Main(string[] args)
    {
        HomeController controller = new();

        SmartLight light = new("Living room light");
        Thermostat thermostat = new("Thermostat");
        SecurityCamera camera = new("Front camera");
        SmartDoorLock door = new("Front door");
        SmartSprinkler sprinkler = new("Garden sprinkler");

        light.TurnOn();
        thermostat.TurnOn();
        camera.TurnOn();

        controller.ShowStatuses(new List<IStatusProvider>
        {
            light,
            thermostat,
            camera,
            door,
            sprinkler
        });

        Console.WriteLine();

        controller.RunDiagnostics(new List<ISelfTestable>
        {
            thermostat,
            camera
        });

        Console.WriteLine();

        controller.UpdateSoftware(new List<ISoftwareUpdatable>
        {
            camera,
            door
        });

        Console.WriteLine();

        controller.SendAlert(new List<INotificationSender>
        {
            camera,
            door
        }, "Suspicious activity detected.");
    }
}
