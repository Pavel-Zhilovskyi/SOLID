namespace CarRepair;

internal class BrakesReplacement : Service
{
    public override string SolvedProblem => IssuesConstants.BrakesReplacement;

    public BrakesReplacement() : base(5000, TimeSpan.FromHours(2))
    {
    }

    public override void Repair(Transport transport)
    {
        transport.RemoveProblem(SolvedProblem);

        Console.WriteLine($"Тормоза поменяны у т.с. {transport.Number}");
    }
}