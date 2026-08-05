namespace CarRepair;

abstract class Transport
{
    public string Number { get; }
    public string Owner { get; }
    public List<string> Problems { get; }

    protected Transport(string number, string owner, List<string> problems)
    {
        Number = number;
        Owner = owner;
        Problems = problems;
    }

    public void RemoveProblem(string problem)
    {
        Problems.Remove(problem);
    }
}