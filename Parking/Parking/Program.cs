namespace ParkingBad;

internal class Program
{
    static void Main()
    {
        var parking = new Parking();

        var vehicles = new List<Vehicle>
        {
            new Car("AA1111AA"),
            new Car("BB2222BB"),
            new ElectricCar("CC3333CC")
        };

        foreach (var vehicle in vehicles)
        {
            vehicle.EnterParking(parking);
        }

        Console.WriteLine("Обслуживание автомобилей:");

        foreach (var vehicle in parking.Vehicles)
        {
            vehicle.Refuel();
        }
    }
}