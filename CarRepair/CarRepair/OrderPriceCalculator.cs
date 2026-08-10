namespace CarRepair;

internal class OrderPriceCalculator
{
    private readonly IReadOnlyCollection<Service> _services;

    public OrderPriceCalculator(IReadOnlyCollection<Service> services)
    {
        _services = services;
    }

    public decimal CalculateTotal()
    {
        decimal totalPrice = 0;

        foreach (var service in _services)
        {
            totalPrice += service.Price;
        }

        return totalPrice;
    }
}