namespace ParkingGood;

internal class ChargingStation
{
    public void Charge(IChargeable vehicle)
    {
        vehicle.Charge();
    }
}