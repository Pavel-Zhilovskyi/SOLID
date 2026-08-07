namespace ParkingBad;

internal class ParkingReporter
{
    public void Print(Parking parking)
    {
        Console.WriteLine("Машины на парковке:");

        foreach (var vehicle in parking.Vehicles)
        {
            Console.WriteLine(vehicle.Plate);
        }
    }
}
