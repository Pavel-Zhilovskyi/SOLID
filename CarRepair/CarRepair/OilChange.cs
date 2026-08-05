namespace CarRepair;

internal class OilChange : Service
{
    public override string SolvedProblem => IssuesConstants.OilChange;

    public OilChange() : base(3000, TimeSpan.FromHours(1))
    {
    }

    public override void Repair(Transport transport)
    {
        transport.RemoveProblem(SolvedProblem);
        Console.WriteLine($"Масло заменено у т.с. {transport.Number}");
    }
}