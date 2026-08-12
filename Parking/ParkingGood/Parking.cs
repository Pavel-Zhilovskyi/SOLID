namespace ParkingGood;

internal class Parking
{
    public List<Car> Vehicles { get; } = new();

    public void ParkCar(Car car)
    {
        car.Park();
        Vehicles.Add(car);

        ParkingTicket ticket = car.CreateParkingTicket();

        Console.WriteLine($"Создан талон для автомобиля {ticket.LicensePlate}: " + $"{ticket.Description}");
    }
}