namespace ParkingGood;

internal class FuelStation
{
    public void Refuel(IRefuelable vehicle)
    {
        vehicle.Refuel();
    }
}