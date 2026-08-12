namespace ChessTournamentManager;

internal class Program
{
    static void Main(string[] args)
    {
        var calculator = new ScoreCalculator();
        var printer = new ResultPrinter();

        var playerJohn = new Player("John Doe");
        var playerPeter= new Player("Petter Griffin");
        var playerLois = new Player("Lois Griffin");

        var tournament = new Tournament();

        var manager = new TournamentManager(tournament);

        manager.AddPlayer(playerJohn);
        manager.AddPlayer(playerPeter);
        manager.AddPlayer(playerLois);

        manager.AddMatch(new Match(playerJohn, playerLois, MatchResult.WhiteWin));
        manager.AddMatch(new Match(playerPeter, playerLois, MatchResult.BlackWin));
        manager.AddMatch(new Match(playerJohn, playerPeter, MatchResult.Draw));

        calculator.CalculateScore(tournament);

        printer.Print(tournament.Players);
    }
}