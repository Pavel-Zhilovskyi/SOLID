namespace FestivalGood;

public class Contest : IEvent
{
    public string Name => "Конкурс талантов";

    public void Prepare()
    {
        Console.WriteLine("Подготавливается сцена.");
    }

    public void Start()
    {
        Console.WriteLine("Участники показывают свои номера.");
    }

    public void Finish()
    {
        Console.WriteLine("Жюри объявляет победителя.");
    }
}