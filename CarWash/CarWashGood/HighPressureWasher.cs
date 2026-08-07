namespace CarWashGood;

internal class HighPressureWasher : IWasher
{
    public void Start()
    {
        Console.WriteLine("Мойка высокого давления включена.");
    }

    public void ApplyFoam(Car car)
    {
        Console.WriteLine($"На {car.Model} нанесена активная пена.");
    }

    public void Wash(Car car)
    {
        Console.WriteLine($"{car.Model} моется водой под высоким давлением.");
    }

    public void WashOff(Car car)
    {
        Console.WriteLine($"Пена смыта с {car.Model}.");
    }

    public void Dry(Car car)
    {
        Console.WriteLine($"{car.Model} высушен.");
    }

    public void Stop()
    {
        Console.WriteLine("Мойка высокого давления выключена.");
    }
}