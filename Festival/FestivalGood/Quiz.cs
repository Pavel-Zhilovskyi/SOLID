namespace FestivalGood;

public class Quiz : IEvent
{
    public string Name => "Викторина";

    public void Prepare()
    {
        Console.WriteLine("Раздаются карточки участникам.");
    }

    public void Start()
    {
        Console.WriteLine("Ведущий задает вопросы.");
    }

    public void Finish()
    {
        Console.WriteLine("Подсчитываются баллы.");
    }
}