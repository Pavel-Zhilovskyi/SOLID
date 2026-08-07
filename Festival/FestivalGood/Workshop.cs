namespace FestivalGood;

public class Workshop : IEvent
{
    public string Name => "Мастер-класс";

    public void Prepare()
    {
        Console.WriteLine("Раскладываются материалы.");
    }

    public void Start()
    {
        Console.WriteLine("Мастер показывает технику.");
    }

    public void Finish()
    {
        Console.WriteLine("Участники забирают свои работы.");
    }
}