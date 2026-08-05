namespace BadVersion;

internal class Vehicle
{
    public string Type;
    public string Number;
    public string Owner;
    public List<string> Problems;

    public Vehicle(string type, string number, string owner, List<string> problems)
    {
        Type = type;
        Number = number;
        Owner = owner;
        Problems = problems;
    }
}