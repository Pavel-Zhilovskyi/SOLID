namespace CinemaBad;

public class MovieSession
{
    private readonly List<string> soldTickets = new();

    public string Title { get; }
    public string Hall { get; }
    public decimal TicketPrice { get; }
    public int TotalSeats { get; }

    public MovieSession(string title, string hall, decimal ticketPrice, int totalSeats)
    {
        Title = title;
        Hall = hall;
        TicketPrice = ticketPrice;
        TotalSeats = totalSeats;
    }

    public void ShowInfo()
    {
        Console.WriteLine("Информация о сеансе");
        Console.WriteLine($"Фильм: {Title}");
        Console.WriteLine($"Зал: {Hall}");
        Console.WriteLine($"Цена билета: {TicketPrice} грн");
        Console.WriteLine($"Свободных мест: {TotalSeats - soldTickets.Count}");
    }

    public void SellTicket(string customer)
    {
        if (soldTickets.Count >= TotalSeats)
        {
            Console.WriteLine($"Для {customer}: мест больше нет.");
            return;
        }

        soldTickets.Add(customer);

        Console.WriteLine($"Продан билет для {customer}");

        PrintTicket(customer);
    }

    public void PrintTicket(string customer)
    {
        Console.WriteLine();
        Console.WriteLine("====== БИЛЕТ ======");
        Console.WriteLine($"Фильм: {Title}");
        Console.WriteLine($"Зал: {Hall}");
        Console.WriteLine($"Посетитель: {customer}");
        Console.WriteLine($"Стоимость: {TicketPrice} грн");
        Console.WriteLine("===================");
        Console.WriteLine();
    }

    public decimal CalculateRevenue()
    {
        return soldTickets.Count * TicketPrice;
    }

    public void SaveReport()
    {
        Console.WriteLine("Сохранение отчета...");

        Console.WriteLine($"Фильм: {Title}");
        Console.WriteLine($"Продано билетов: {soldTickets.Count}");
        Console.WriteLine($"Выручка: {CalculateRevenue()} грн");

        Console.WriteLine("Отчет успешно сохранен.");
    }
}