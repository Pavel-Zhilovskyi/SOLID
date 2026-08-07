namespace FestivalBad;

public class Quiz
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