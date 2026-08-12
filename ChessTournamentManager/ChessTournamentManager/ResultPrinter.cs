namespace ChessTournamentManager;

internal class ResultPrinter
{
    public void Print(List<Player> players)
    {
        Console.WriteLine("Tournament results");
        Console.WriteLine("--------------------");

        foreach (var player in players)
        {
            Console.WriteLine($"{player.Name} - {player.Points}");
        }
    }
}