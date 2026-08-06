namespace DeliverySystem;

internal abstract class DeliverySevice
{
    public abstract decimal CalculateCost(Order order);
    public abstract int CalculateDays(Order order);
    public abstract Receipt Deliver(Order order);
}