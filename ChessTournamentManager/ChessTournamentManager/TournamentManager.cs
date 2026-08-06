namespace ChessTournamentManager;

internal class TournamentManager
{
    public void AddPlayer(Tournament tournament,  Player player)
    {
        tournament.Players.Add(player);
    }

    public void AddMatch(Tournament tournament, Match match)
    {
        tournament.Matches.Add(match);
    }
}