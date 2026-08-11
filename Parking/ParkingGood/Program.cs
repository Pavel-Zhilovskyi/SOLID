namespace ParkingGood;

internal class Program
{
    static void Main(string[] args)
    {
        var parking = new Parking(); 

        var regularCar = new Car("AP1234BB");
        var electricCar = new ElectricCar("AT5678CE");

        parking.ParkCar(regularCar);

        Console.WriteLine();

        parking.ParkCar(electricCar);
    }
}