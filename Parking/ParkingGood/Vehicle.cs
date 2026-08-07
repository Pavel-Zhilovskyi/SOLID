namespace ParkingGood;

internal abstract class Vehicle
{
    public string Plate { get; }

    protected Vehicle(string plate)
    {
        Plate = plate;
    }

    public virtual void EnterParking(Parking parking)
    {
        parking.AddVehicle(this);

        Console.WriteLine($"{Plate} въехал на парковку.");
    }

    public virtual void LeaveParking(Parking parking)
    {
        parking.RemoveVehicle(this);

        Console.WriteLine($"{Plate} покинул парковку.");
    }
}