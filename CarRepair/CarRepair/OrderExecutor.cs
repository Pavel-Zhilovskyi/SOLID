namespace CarRepair;

internal class OrderExecutor
{
    private readonly Transport _transport;
    private readonly IReadOnlyCollection<Service> _services;

    public OrderExecutor(Transport transport, IReadOnlyCollection<Service> services)
    {
        _transport = transport;
        _services = services;
    }

    public void Execute()
    {
        foreach (var service in _services)
        {
            service.Repair(_transport);
            Console.WriteLine($"Стоимость: {service.Price} грн.");
        }
    }
}
