using ChessTournamentManager;

internal class TournamentManager
{
    private readonly Tournament _tournament;

    public TournamentManager(Tournament tournament)
    {
        _tournament = tournament;
    }

    public void AddPlayer(Player player)
    {
        _tournament.Players.Add(player);
    }

    public void AddMatch(Match match)
    {
        _tournament.Matches.Add(match);
    }
}