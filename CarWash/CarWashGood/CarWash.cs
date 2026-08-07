namespace CarWashGood;

internal class CarWash
{
    private readonly Queue<Car> queue = new();

    private readonly IWasher washer;

    public CarWash(IWasher washer)
    {
        this.washer = washer;
    }

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

        while (queue.Count > 0)
        {
            Car car = queue.Dequeue();

            Console.WriteLine($"{car.Model} заехал на мойку.");

            PrepareCar(car);

            washer.Start();

            washer.ApplyFoam(car);

            washer.Wash(car);

            washer.WashOff(car);

            washer.Dry(car);

            washer.Stop();

            FinishCar(car);

            Console.WriteLine(new string('-', 40));
        }
    }

    private void PrepareCar(Car car)
    {
        Console.WriteLine($"Подготавливаем {car.Model} к мойке.");
    }

    private void FinishCar(Car car)
    {
        Console.WriteLine($"{car.Model} покинул автомойку.");
    }
}