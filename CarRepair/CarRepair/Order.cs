namespace CarRepair;

internal class Order
{
    public int Number { get; private set; }
    public Transport Transport { get; private set; }
    public IReadOnlyCollection<Service> Services { get; private set; }

    public Order(int number, Transport transport, IReadOnlyCollection<Service> services)
    {
        Number = number;
        Transport = transport;
        Services = services;
    }

    public decimal CountPrice()
    {
        var calculator = new OrderPriceCalculator(Services);
        return calculator.CalculateTotal();
    }

    public TimeSpan CountHoursToComplete()
    {
        var calculator = new OrderTimeCalculator(Services);
        return calculator.CalculateTotal();
    }

    public void CompleteOrder()
    {
        var executor = new OrderExecutor(Transport, Services);
        executor.Execute();
    }
}