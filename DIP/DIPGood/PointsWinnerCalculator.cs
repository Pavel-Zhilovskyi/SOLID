namespace DIPGood;

internal class PointsWinnerCalculator : IWinnerCalculator
{
    public Player GetWinner(Player p1, Player p2)
    {
        return p1.Points >= p2.Points ? p1 : p2;
    }
}