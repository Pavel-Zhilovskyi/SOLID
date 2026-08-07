namespace FestivalBad;

public class Festival
{
    public void Open(List<object> events)
    {
        Console.WriteLine("Фестиваль начинается.\n");

        foreach (var e in events)
        {
            if (e is Contest contest)
            {
                Console.WriteLine($"=== {contest.Name} ===");

                contest.Prepare();
                contest.Start();
                contest.Finish();
            }
            else if (e is Quiz quiz)
            {
                Console.WriteLine($"=== {quiz.Name} ===");

                quiz.Prepare();
                quiz.Start();
                quiz.Finish();
            }
            else if (e is Workshop workshop)
            {
                Console.WriteLine($"=== {workshop.Name} ===");

                workshop.Prepare();
                workshop.Start();
                workshop.Finish();
            }
            else if (e is Lecture lecture)
            {
                Console.WriteLine($"=== {lecture.Name} ===");

                lecture.Prepare();
                lecture.Start();
                lecture.Finish();
            }

            Console.WriteLine();
        }
        Console.WriteLine("Все мероприятия завершены.");
    }
}