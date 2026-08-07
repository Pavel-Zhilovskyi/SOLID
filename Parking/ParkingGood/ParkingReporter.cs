namespace ParkingGood;

internal class ParkingReporter
{
    public void Print(Parking parking)
    {
        Console.WriteLine("Автомобили на парковке:");

        foreach (var vehicle in parking.Vehicles)
        {
            Console.WriteLine(vehicle.Plate);
        }
    }
}