namespace DeliverySystem;

internal class ExpressDelivery : PostDelivery
{
    public override decimal CalculateCost(Order order)
    {
        return (int)order.Distance * order.ItemsCost * (int)order.Weight / 1000;
    }

    public override int CalculateDays(Order order)
    {
        return 1;
    }

    public override Receipt Deliver(Order order)
    {
        string trackingNumber = Random.Shared.Next(1, 1000).ToString();
        decimal cost = CalculateCost(order);
        int days = CalculateDays(order);

        return new Receipt(trackingNumber, order.Id, cost, days);
    }
}