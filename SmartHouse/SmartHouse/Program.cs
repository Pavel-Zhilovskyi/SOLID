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

        controller.ShowStatuses(new IStatusProvider[]
        {
            light,
            thermostat,
            camera,
            door,
            sprinkler
        });

        Console.WriteLine();

        controller.RunDiagnostics(new ISelfTestable[]
        {
            thermostat,
            camera
        });

        Console.WriteLine();

        controller.UpdateSoftware(new ISoftwareUpdatable[]
        {
            camera,
            door
        });

        Console.WriteLine();

        controller.SendAlert(new INotificationSender[]
        {
            camera,
            door
        }, "Suspicious activity detected.");
    }
}
