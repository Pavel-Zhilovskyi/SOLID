namespace ParkingGood;

internal class Parking
{
    private readonly List<Car> _vehicles = new();

    public IReadOnlyList<Car> Vehicles => _vehicles;

    public void ParkCar(Car car)
    {
        car.Park();
        _vehicles.Add(car);

        ParkingTicket ticket = car.CreateParkingTicket();

        Console.WriteLine(
            $"Создан талон для автомобиля {ticket.LicensePlate}: " + $"{ticket.Description}");
    }
}