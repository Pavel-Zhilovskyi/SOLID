namespace ParkingBad;

abstract class Vehicle
{
    public string Plate { get; }

    protected Vehicle(string plate)
    {
        Plate = plate;
    }

    public abstract void EnterParking(Parking parking);

    public abstract void LeaveParking(Parking parking);

    public abstract void Refuel();
}