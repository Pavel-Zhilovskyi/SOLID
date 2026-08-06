using BadSRPVersion;

class Program
{
    static void Main()
    {
        TournamentManager manager = new();

        Player magnus = new("Magnus Carlsen");
        Player hikaru = new("Hikaru Nakamura");
        Player ian = new("Ian Nepomniachtchi");

        manager.AddPlayer(magnus);
        manager.AddPlayer(hikaru);
        manager.AddPlayer(ian);

        manager.AddMatch(new Match(magnus, hikaru, MatchResult.WhiteWin));
        manager.AddMatch(new Match(magnus, ian, MatchResult.Draw));
        manager.AddMatch(new Match(hikaru, ian, MatchResult.BlackWin));

        manager.CalculateScores();

        manager.PrintResults();

        manager.SaveResults();
    }
}