namespace ParkingGood;

internal class Car : Vehicle, IRefuelable
{
    public Car(string plate) : base(plate)
    {
    }

    public void Refuel()
    {
        Console.WriteLine($"{Plate} заправлен бензином.");
    }
}