namespace DIPGood;

internal class Program
{
    static void Main(string[] args)
    {
        IWinnerCalculator killsCalculator = new KillsWinnerCalculator();
        IWinnerCalculator pointsCalculator = new PointsWinnerCalculator();

        var player1 = new Player("Player 1", 10, 60, 1000);
        var player2 = new Player("Player 2", 15, 75, 1500);

        var tournament = new Tournament(killsCalculator);

        tournament.FinishTournament(player1, player2);

        tournament = new Tournament(pointsCalculator);

        tournament.FinishTournament(player1, player2);
    }
}