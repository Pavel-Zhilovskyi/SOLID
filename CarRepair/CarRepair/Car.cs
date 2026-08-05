namespace CarRepair;

internal class Car : Transport
{
    public Car(string number, string name, List<string> problems)
        : base(number, name, problems)
    {
    }
}