namespace DIPGood;

internal class Tournament
{
    private readonly IWinnerCalculator calculator;

    public Tournament(IWinnerCalculator calculator)
    {
        this.calculator = calculator;
    }

    public void FinishTournament(Player p1, Player p2)
    {
        var winner = calculator.GetWinner(p1, p2);
        Console.WriteLine($"Winner: {winner.Name}");
    }
}