using System.Text;

namespace ChessTournamentManager;

internal class TournamentSaver
{
    private string _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Report.txt");

    public void Save(IEnumerable<Player> players)
    {
        StringBuilder builder = new();

        builder.AppendLine("Tournament results");
        builder.AppendLine("------------------");

        foreach (var player in players)
        {
            builder.AppendLine($"{player.Name} - {player.Points}");
        }

        builder.AppendLine();

        File.AppendAllText(_filePath, builder.ToString());
    }
}