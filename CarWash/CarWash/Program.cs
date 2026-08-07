namespace CarWashBad;

internal class Program
{
    static void Main()
    {
        var carWash = new CarWash();

        carWash.AddCar(new Car("Ford Sierra"));
        carWash.AddCar(new Car("BMW X5M"));
        carWash.AddCar(new Car("BMW M5"));

        Console.WriteLine();

        carWash.StartWorking();
    }
}