namespace FestivalGood;

public class Lecture : IEvent
{
    public string Name => "Лекция";

    public void Prepare()
    {
        Console.WriteLine("Настраивается проектор.");
    }

    public void Start()
    {
        Console.WriteLine("Лектор начинает выступление.");
    }

    public void Finish()
    {
        Console.WriteLine("Ответы на вопросы слушателей.");
    }
}