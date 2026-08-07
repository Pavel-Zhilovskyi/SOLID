namespace CarWashGood;

internal class FoamWasher : IWasher
{
    public void Start()
    {
        Console.WriteLine("Пенная мойка включена.");
    }

    public void ApplyFoam(Car car)
    {
        Console.WriteLine($"{car.Model} полностью покрыт активной пеной.");
    }

    public void Wash(Car car)
    {
        Console.WriteLine("Машина откисает в пене.");
    }

    public void WashOff(Car car)
    {
        Console.WriteLine($"Пена смыта с {car.Model}.");
    }

    public void Dry(Car car)
    {
        Console.WriteLine($"{car.Model} высушен воздухом.");
    }

    public void Stop()
    {
        Console.WriteLine("Пенная мойка выключена.");
    }
}