namespace CinemaGood;

public class TicketSeller
{
    private readonly TicketPrinter printer = new TicketPrinter();

    public void Sell(MovieSession session, string customer)
    {
        if (session.SoldTickets.Count >= session.TotalSeats)
        {
            Console.WriteLine($"Для {customer}: мест больше нет.");
            return;
        }

        session.SoldTickets.Add(customer);

        Console.WriteLine($"Продан билет для {customer}");

        printer.Print(session, customer);
    }
}