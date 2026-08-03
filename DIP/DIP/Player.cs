namespace DIPBad;

internal class Player
{
    public string Name { get; private set; }
    public int Kills { get; private set; }
    public int Points { get; private set; }
    public int Damage { get; private set; }

    public Player(string name, int kills, int points, int damage)
    {
        Name = name;
        Kills = kills;
        Points = points;
        Damage = damage;
    }
}