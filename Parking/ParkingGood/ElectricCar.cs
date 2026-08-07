namespace ParkingGood;

internal class ElectricCar : Vehicle, IChargeable
{
    public ElectricCar(string plate) : base(plate)
    {
    }

    public void Charge()
    {
        Console.WriteLine($"{Plate} заряжен.");
    }
}