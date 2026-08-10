namespace DeliverySystem;

internal class OrderProcessor
{
    public static void ProcessAndPrint(PostDelivery service, Order order)
    {
        Receipt receipt = service.Deliver(order);
        decimal total = order.ItemsCost + receipt.DeliveryCost;

        Console.WriteLine($"{service.GetType().Name} {receipt}");
        Console.WriteLine($"Total: {total}");
        Console.WriteLine();
    }
}