namespace ParkingGood;

internal class Car
{
    public string LicensePlate { get; }

    public Car(string licensePlate)
    {
        LicensePlate = licensePlate;
    }

    public virtual void Park()
    {
        Console.WriteLine($"Автомобиль {LicensePlate} припаркован.");
    }

    public virtual ParkingTicket CreateParkingTicket()
    {
        return new ParkingTicket(LicensePlate, "Обычный парковочный талон");
    }
}