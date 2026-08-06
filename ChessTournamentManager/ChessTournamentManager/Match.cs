namespace ChessTournamentManager;

internal class Match
{
    public Player WhitePlayer { get; }
    public Player BlackPlayer { get; }
    public MatchResult Result { get; }

    public Match(Player whitePlayer, Player blackPlayer, MatchResult result)
    {
        WhitePlayer = whitePlayer;
        BlackPlayer = blackPlayer;
        Result = result;
    }
}