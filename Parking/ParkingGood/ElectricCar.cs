namespace ParkingGood;

internal class ElectricCar : Car
{
    public ElectricCar(string licensePlate) : base(licensePlate)
    {
    }

    public override void Park()
    {
        Console.WriteLine($"Электромобиль {LicensePlate} припаркован.");
    }

    public override ElectricParkingTicket CreateParkingTicket()
    {
        return new ElectricParkingTicket(LicensePlate, "Парковочный талон для электромобиля", true);
    }
}