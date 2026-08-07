namespace FestivalGood;

internal class Program
{
    static void Main()
    {
        var events = new List<IEvent>
        {
            new Contest(),
            new Quiz(),
            new Workshop(),
            new Lecture()
        };

        var festival = new Festival(events);

        festival.Open();
    }
}