namespace BadSRPVersion;

internal class TournamentManager
{
    private readonly List<Player> _players = [];
    private readonly List<Match> _matches = [];

    private string _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "BadSRPReport.txt");

    public void AddPlayer(Player player)
    {
        _players.Add(player);
    }

    public void AddMatch(Match match)
    {
        _matches.Add(match);
    }

    public void CalculateScores()
    {
        foreach (var player in _players)
        {
            player.Points = 0;
        }

        foreach (var match in _matches)
        {
            switch (match.Result)
            {
                case MatchResult.WhiteWin:
                    match.WhitePlayer.Points++;
                    break;

                case MatchResult.BlackWin:
                    match.BlackPlayer.Points++;
                    break;

                case MatchResult.Draw:
                    break;
            }
        }
    }

    public void PrintResults()
    {
        Console.WriteLine("Tournament results");
        Console.WriteLine("------------------");

        foreach (var player in _players)
        {
            Console.WriteLine($"{player.Name} - {player.Points}");
        }
    }

    public void SaveResults()
    {
        File.AppendAllText(_filePath, "Tournament results\n");
        File.AppendAllText(_filePath, "------------------\n");

        foreach (var player in _players)
        {
            File.AppendAllText(_filePath, $"{player.Name} - {player.Points}\n");
        }

        File.AppendAllText(_filePath, "\n");
    }
}