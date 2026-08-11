namespace ParkingGood;

internal class ParkingReporter
{
    public void Print(Parking parking)
    {
        Console.WriteLine("Автомобили на парковке:");

        foreach (var car in parking.Vehicles)
        {
            Console.WriteLine(car.LicensePlate);
        }
    }
}