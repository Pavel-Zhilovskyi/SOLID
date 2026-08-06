namespace ChessTournamentManager;

internal class Program
{
    static void Main(string[] args)
    {
        var tournament = new Tournament();

        var manager = new TournamentManager();
        var calculator = new ScoreCalculator();
        var printer = new ResultPrinter();
        var saver = new TournamentSaver();

        var playerJohn = new Player("John Doe");
        var playerPeter= new Player("Petter Griffin");
        var playerLois = new Player("Lois Griffin");

        manager.AddPlayer(tournament, playerJohn);
        manager.AddPlayer(tournament, playerPeter);
        manager.AddPlayer(tournament, playerLois);

        manager.AddMatch(tournament, new Match(playerJohn, playerLois, MatchResult.WhiteWin));
        manager.AddMatch(tournament, new Match(playerPeter, playerLois, MatchResult.BlackWin));
        manager.AddMatch(tournament, new Match(playerJohn, playerPeter, MatchResult.Draw));

        calculator.CalculateScore(tournament);

        printer.Print(tournament.Players);

        saver.Save(tournament.Players);
    }
}