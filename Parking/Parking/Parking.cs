using System.Numerics;

namespace ParkingBad;

internal class Parking
{
    private List<Vehicle> vehicles = new List<Vehicle>();
    public IReadOnlyList<Vehicle> Vehicles => vehicles; 

    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
        Console.WriteLine($"{vehicle.Plate} въехал на парковку.\n");
    }

    public void RemoveVehicle(Vehicle vehicle)
    {
        vehicles.Remove(vehicle);
        Console.WriteLine($"{vehicle.Plate} покинул парковку.\n");
    }
}