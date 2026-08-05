namespace CarRepair;

internal class Order
{
    public int Number { get; }
    private readonly Transport _transport;

    private readonly IReadOnlyCollection<Service> _services;

    public Order(int number, Transport transport, IReadOnlyCollection<Service> services)
    {
        Number = number;
        _transport = transport;
        _services = services;
    }

    public decimal CountPrice()
    {
        decimal totalPrice = 0;
        
        foreach (var service in _services)
        {
            totalPrice += service.Price;
        }

        return totalPrice;
    }

    public TimeSpan CountHoursToComplete()
    {
        TimeSpan totalHours = TimeSpan.Zero;
        
        foreach (var service in _services)
        {
            totalHours += service.HoursToComplete;
        }
     
        return totalHours;
    }

    public void CompleteOrder()
    {
        foreach (var service in _services)
        {
            service.Repair(_transport);
            Console.WriteLine($"Стоимость: {service.Price} грн.");
        }
    }
}