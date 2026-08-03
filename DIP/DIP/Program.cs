namespace DIPBad;

internal class Program
{
    static void Main(string[] args)
    {
        var calculator = new KillsWinnerCalculator();
        //var pointsCalculator = new PointsWinnerCalculator();
        var tournament = new Tournament(calculator/*, pointsCalculator*/);

        var player1 = new Player("Player 1", 10, 60, 1000);
        var player2 = new Player("Player 2", 15, 75, 1500);

        tournament.FinishTournament(player1, player2);
        //tournament.FinishTournamentWithPoints(player1, player2);
    }
}
