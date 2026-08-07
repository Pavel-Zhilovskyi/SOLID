namespace CinemaGood;

internal class Program
{
    static void Main()
    {
        var session = new MovieSession("Интерстеллар", "Зал №2", 250, 5);

        var infoPrinter = new SessionInfoPrinter();
        var seller = new TicketSeller();
        var calculator = new IncomeCalculator();
        var saver = new ReportSaver();

        infoPrinter.Print(session);

        seller.Sell(session, "Иван");
        seller.Sell(session, "Анна");
        seller.Sell(session, "Максим");

        Console.WriteLine();

        decimal revenue = calculator.Calculate(session);

        Console.WriteLine($"Выручка: {revenue} грн");

        Console.WriteLine();

        saver.Save(session, revenue);
    }
}