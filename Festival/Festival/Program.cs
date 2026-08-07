namespace FestivalBad;

internal class Program
{
    static void Main()
    {
        var events = new List<object>
        {
            new Contest(),
            new Quiz(),
            new Workshop(),
            new Lecture()
        };

        var festival = new Festival();

        festival.Open(events);
    }
}