namespace DeliverySystem;

internal class Program
{
    static void Main(string[] args)
    {
        var orders = new List<Order>()
        {
            new Order(1, 25, 10, 2000),
            new Order(2, 10, 15, 1000),
            new Order(2, 200, 100, 5000),
        };

        var services = new List<DeliverySevice>()
        {
            new CourierDelivery(),
            new ExpressDelivery(),
            new PostDelivery()
        };

        foreach (var order in orders)
        {
            Console.WriteLine($"=== {order} ===");
            foreach (var service in services)
            {
                OrderProcessor.ProcessAndPrint(service, order);
            }
        }
    }
}