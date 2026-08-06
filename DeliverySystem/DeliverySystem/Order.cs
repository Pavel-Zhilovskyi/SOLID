namespace DeliverySystem;

internal class Order
{
    public int Id { get; }
    public double Weight { get; }
    public double Distance { get; }
    public decimal ItemsCost { get; }

    public Order(int id, double weight, double distance, decimal itemsCost)
    {
        if (weight <= 0)
            throw new ArgumentException("Weight must be positive.");
        if (distance < 0)
            throw new ArgumentException("Distance cannot be negative.");
        if (itemsCost < 0)
            throw new ArgumentException("Items cost cannot be negative.");

        Id = id;
        Weight = weight;
        Distance = distance;
        ItemsCost = itemsCost;
    }

    public override string ToString()
    {
        return $"Order #{Id} Weight: {Weight}kg, Distance: {Distance}km, ItemsCost: {ItemsCost}";
    }
}