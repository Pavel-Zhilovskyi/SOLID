using CarRepair;

internal abstract class Service 
{
    public abstract string SolvedProblem { get; }

    public decimal Price { get; }

    public TimeSpan HoursToComplete { get; }

    protected Service(decimal price, TimeSpan hoursToComplete)
    {
        if (price <= 0)
            throw new ArgumentOutOfRangeException();

        if (hoursToComplete <= TimeSpan.Zero)
            throw new ArgumentOutOfRangeException();

        Price = price;
        HoursToComplete = hoursToComplete;
    }

    public abstract void Repair(Transport transport);
}