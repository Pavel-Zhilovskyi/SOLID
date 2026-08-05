namespace CarRepair;

internal class Program
{
    static void Main(string[] args)
    {
        var motorycle = new Motorcycle("AP123BC", "John Doe", new List<string> { IssuesConstants.BrakesReplacement, IssuesConstants.OilChange });

        var lorry = new Lorry("AA456DY", "Та самая собака из казика", new List<string> { IssuesConstants.Diagnostics });

        var car = new Car("AT4146IH", "Peter Griffin", new List<string> { IssuesConstants.Diagnostics, IssuesConstants.OilChange, IssuesConstants.BrakesReplacement });
        var car2 = new Car("AT9812IH", "Lois Griffin", new List<string> { IssuesConstants.Diagnostics, IssuesConstants.OilChange});
        
        var order1 = new Order(1, motorycle, new List<Service> { new BrakesReplacement(), new OilChange() });
        Console.WriteLine($"Заказ №{order1.Number}");
        order1.CompleteOrder();

        Console.WriteLine($"\nИтого: {order1.CountPrice()} грн");
        Console.WriteLine($"Время затрачено на работу: {order1.CountHoursToComplete()}\n");

        var order2 = new Order(2, car, new List<Service> { new Diagnostics(), new OilChange(), new BrakesReplacement() });
        Console.WriteLine($"Заказ №{order2.Number}");
        order2.CompleteOrder();

        Console.WriteLine($"\nИтого: {order2.CountPrice()} грн");
        Console.WriteLine($"Время затрачено на работу: {order2.CountHoursToComplete()}");
    }
}