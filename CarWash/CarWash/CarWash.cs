namespace CarWashBad;

internal class CarWash
{
    private readonly Queue<Car> queue = new Queue<Car>();

    public void AddCar(Car car)
    {
        queue.Enqueue(car);

        Console.WriteLine($"{car.Model} добавлен в очередь.");
    }

    public void StartWorking()
    {
        Console.WriteLine();
        Console.WriteLine("Автомойка начала работу.");
        Console.WriteLine();

        HighPressureWasher washer = new HighPressureWasher();

        while (queue.Count > 0)
        {
            Car car = queue.Dequeue();

            Console.WriteLine($"{car.Model} заехал на мойку.");

            washer.Start();

            washer.ApplyFoam(car);

            washer.Wash(car);

            washer.WashOff(car);

            washer.Dry(car);

            washer.Stop();

            Console.WriteLine($"{car.Model} покинул автомойку.");
            Console.WriteLine(new string('-', 35));
        }
    }
}