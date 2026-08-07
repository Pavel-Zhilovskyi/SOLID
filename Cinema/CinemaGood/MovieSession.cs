namespace CinemaGood;

public class MovieSession
{
    public string Title { get; }
    public string Hall { get; }
    public decimal TicketPrice { get; }
    public int TotalSeats { get; }

    public List<string> SoldTickets { get; } = new();

    public MovieSession(string title, string hall, decimal ticketPrice, int totalSeats)
    {
        Title = title;
        Hall = hall;
        TicketPrice = ticketPrice;
        TotalSeats = totalSeats;
    }
}