namespace ChessTournamentManager;

internal class ScoreCalculator
{
    public void CalculateScore(Tournament tournament)
    {
        foreach(var player in tournament.Players)
        {
            player.Points = 0;
        }

        foreach(var match in tournament.Matches)
        {
            switch (match.Result)
            {
                case MatchResult.WhiteWin:
                    match.WhitePlayer.Points += 1;
                    break;

                case MatchResult.BlackWin:
                    match.BlackPlayer.Points += 1;
                    break;

                case MatchResult.Draw:
                    break;
            }
        }
    }
}