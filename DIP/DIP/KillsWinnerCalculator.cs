namespace DIPBad;

internal class KillsWinnerCalculator
{
    public Player GetWinner(Player p1, Player p2)
    {
        return p1.Kills >= p2.Kills ? p1 : p2;
    }
}
