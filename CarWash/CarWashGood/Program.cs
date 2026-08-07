namespace CarWashGood;

internal class Program
{
    static void Main()
    {
        IWasher washer = new FoamWasher();
        // IWasher washer = new HighPressureWasher();

        var carWash = new CarWash(washer);

        carWash.AddCar(new Car("Toyota Camry"));
        carWash.AddCar(new Car("BMW X5"));
        carWash.AddCar(new Car("Tesla Model S"));

        Console.WriteLine();

        carWash.StartWorking();
    }
}