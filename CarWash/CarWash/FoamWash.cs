namespace CarWashBad;

internal class FoamWasher
{
    public void Start()
    {
        Console.WriteLine("Пенная мойка включена.");
    }

    public void CoverWithFoam(Car car)
    {
        Console.WriteLine($"{car.Model} полностью покрыта пеной.");
    }

    public void Wait()
    {
        Console.WriteLine("Машина откисает в пене.");
    }

    public void WashOff(Car car)
    {
        Console.WriteLine($"Пена смыта с {car.Model}.");
    }

    public void Stop()
    {
        Console.WriteLine("Пенная мойка выключена.");
    }
}