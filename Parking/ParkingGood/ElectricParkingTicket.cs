namespace ParkingGood;

internal class ElectricParkingTicket : ParkingTicket
{
    public bool ChargingAvailable { get; }

    public ElectricParkingTicket(string licensePlate, string description, bool chargingAvailable) 
        : base(licensePlate, description)
    {
        ChargingAvailable = chargingAvailable;
    }
}