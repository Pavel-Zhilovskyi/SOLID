namespace CarRepair;

internal class OrderTimeCalculator
{
    private readonly IReadOnlyCollection<Service> _services;

    public OrderTimeCalculator(IReadOnlyCollection<Service> services)
    {
        _services = services;
    }

    public TimeSpan CalculateTotal()
    {
        TimeSpan totalHours = TimeSpan.Zero;

        foreach (var service in _services)
        {
            totalHours += service.HoursToComplete;
        }

        return totalHours;
    }
}
