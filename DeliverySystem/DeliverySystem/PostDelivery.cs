namespace DeliverySystem;

internal class PostDelivery : DeliverySevice
{
    public override decimal CalculateCost(Order order)
    {
        return (int)order.Distance * order.ItemsCost * (int)order.Weight / 100000;
    }

    public override int CalculateDays(Order order)
    {
        if (order.Distance <= 10) return 2;
        if (order.Distance <= 50) return 3;
        return 5;
    }

    public override Receipt Deliver(Order order)
    {
        string trackingNumber = Random.Shared.Next(1, 1000).ToString();
        decimal cost = CalculateCost(order);
        int days = CalculateDays(order);

        return new Receipt(trackingNumber, order.Id, cost, days);
    }
}