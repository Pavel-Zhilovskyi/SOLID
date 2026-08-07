namespace CinemaGood;

public class TicketPrinter
{
    public void Print(MovieSession session, string customer)
    {
        Console.WriteLine();
        Console.WriteLine("====== БИЛЕТ ======");
        Console.WriteLine($"Фильм: {session.Title}");
        Console.WriteLine($"Зал: {session.Hall}");
        Console.WriteLine($"Посетитель: {customer}");
        Console.WriteLine($"Стоимость: {session.TicketPrice} грн");
        Console.WriteLine("===================");
        Console.WriteLine();
    }
}