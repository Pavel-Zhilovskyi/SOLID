namespace ParkingGood;

internal class ParkingTicket
{
    public string LicensePlate { get; }
    public string Description { get; }

    public ParkingTicket(string licensePlate, string description)
    {
        LicensePlate = licensePlate;
        Description = description;
    }
}