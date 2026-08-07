namespace ParkingGood;

internal class Program
{
    static void Main()
    {
        var parking = new Parking();

        var car = new Car("AA1111AA");
        var secondCar = new Car("BB2222BB");
        var electricCar = new ElectricCar("CC3333CC");

        car.EnterParking(parking);
        secondCar.EnterParking(parking);
        electricCar.EnterParking(parking);

        Console.WriteLine();

        var reporter = new ParkingReporter();
        reporter.Print(parking);

        Console.WriteLine();

        var fuelStation = new FuelStation();
        fuelStation.Refuel(car);
        fuelStation.Refuel(secondCar);

        Console.WriteLine();

        var chargingStation = new ChargingStation();
        chargingStation.Charge(electricCar);
    }
}