namespace CinemaBad;

internal class Program
{
    static void Main()
    {
        var session = new MovieSession(
            "Интерстеллар",
            "Зал №2",
            250,
            5);

        session.ShowInfo();

        session.SellTicket("Иван");
        session.SellTicket("Анна");
        session.SellTicket("Максим");

        Console.WriteLine();

        Console.WriteLine($"Выручка: {session.CalculateIncome()} грн");

        Console.WriteLine();

        session.SaveReport();
    }
}