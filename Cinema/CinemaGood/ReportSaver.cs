namespace CinemaGood;

public class ReportSaver
{
    public void Save(MovieSession session, decimal revenue)
    {
        Console.WriteLine("Сохранение отчета...");

        Console.WriteLine($"Фильм: {session.Title}");
        Console.WriteLine($"Продано билетов: {session.SoldTickets.Count}");
        Console.WriteLine($"Выручка: {revenue} грн");

        Console.WriteLine("Отчет успешно сохранен.");
    }
}