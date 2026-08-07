namespace ParkingGood;

internal class Parking
{
    private readonly List<Vehicle> vehicles = new();

    public IReadOnlyList<Vehicle> Vehicles => vehicles;

    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public void RemoveVehicle(Vehicle vehicle)
    {
        vehicles.Remove(vehicle);
    }
}