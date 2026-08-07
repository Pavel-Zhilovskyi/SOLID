namespace CinemaGood;

public class SessionInfoPrinter
{
    public void Print(MovieSession session)
    {
        Console.WriteLine("Информация о сеансе");
        Console.WriteLine($"Фильм: {session.Title}");
        Console.WriteLine($"Зал: {session.Hall}");
        Console.WriteLine($"Цена билета: {session.TicketPrice} грн");
        Console.WriteLine($"Свободных мест: {session.TotalSeats - session.SoldTickets.Count}");
    }
}