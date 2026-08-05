namespace CarRepair;

internal class Diagnostics : Service
{
    public override string SolvedProblem => IssuesConstants.Diagnostics;

    public Diagnostics() : base(2000, TimeSpan.FromHours(3))
    {
    }

    public override void Repair(Transport transport)
    {
        transport.RemoveProblem(SolvedProblem);
        Console.WriteLine($"Диагностика проведена у т.с. {transport.Number}");
    }
}