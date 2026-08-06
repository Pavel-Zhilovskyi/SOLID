namespace ChessTournamentManager;

internal class Player
{
    public string Name { get; set; }
    public int Points { get; set; }

    public Player(string name)
    {
        Name = name;
    }
}