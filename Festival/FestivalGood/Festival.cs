namespace FestivalGood;

public class Festival
{
    private readonly List<IEvent> events;

    public Festival(List<IEvent> events)
    {
        this.events = events;
    }

    public void Open()
    {
        Console.WriteLine("Фестиваль начинается.\n");

        foreach (var e in events)
        {
            Console.WriteLine($"=== {e.Name} ===");

            e.Prepare();
            e.Start();
            e.Finish();

            Console.WriteLine();
        }
        Console.WriteLine("Все мероприятия завершены.");
    }
}