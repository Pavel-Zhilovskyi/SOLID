namespace DeliverySystem;

internal class Receipt
{
    public string TrackingNumber { get; }
    public int OrderId { get; }
    public decimal DeliveryCost { get; }
    public int DaysCount { get; }
    public DateTime ArrivalDate { get; }

    public Receipt(string trackingNumber, int orderId, decimal deliveryCost, int estimatedDays)
    {
        if (string.IsNullOrWhiteSpace(trackingNumber))
            throw new ArgumentException("Tracking number can`t be empty.");
        if (deliveryCost < 0)
            throw new ArgumentException("Delivery cost can`t be negative.");
        if (estimatedDays < 1)
            throw new ArgumentException("Estimated days must be at least 1.");

        TrackingNumber = trackingNumber;
        OrderId = orderId;
        DeliveryCost = deliveryCost;
        DaysCount = estimatedDays;
        ArrivalDate = DateTime.Now.AddDays(estimatedDays);
    }

    public override string ToString()
    {
        return $"Receipt {TrackingNumber} Order #{OrderId}: " +
               $"Cost = {DeliveryCost}, Time = {DaysCount} day(s) " +
               $"Arrival: {ArrivalDate}";
    }
}