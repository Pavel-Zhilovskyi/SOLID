using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaGood;

internal class IncomeCalculator
{
    public decimal Calculate(MovieSession session)
    {
        return session.SoldTickets.Count * session.TicketPrice;
    }
}
