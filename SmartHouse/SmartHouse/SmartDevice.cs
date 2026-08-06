namespace SmartHouse;

internal abstract class SmartDevice
{
    public string Name { get; }
    public bool IsOn { get; protected set; }

    protected SmartDevice(string name)
    {
        Name = name;
    }

    public virtual void TurnOn()
    {
        IsOn = true;
    }

    public virtual void TurnOff()
    {
        IsOn = false;
    }
}