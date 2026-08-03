namespace DIPBad;

internal class Tournament
{
    KillsWinnerCalculator calculator;
    //PointsWinnerCalculator pointsWinnerCalculator;

    public Tournament(KillsWinnerCalculator calculator/*, PointsWinnerCalculator pointsWinnerCalculator*/)
    {
        this.calculator = calculator;
        //this.pointsWinnerCalculator = pointsWinnerCalculator;
    }

    public void FinishTournament(Player p1, Player p2)
    {
        var winner = calculator.GetWinner(p1, p2);
        Console.WriteLine($"Winner: {winner.Name}");
    }

    //public void FinishTournamentWithPoints(Player p1, Player p2)
    //{
    //    var winner = pointsWinnerCalculator.GetWinner(p1, p2);
    //    Console.WriteLine($"Winner: {winner.Name}");
    //}
}