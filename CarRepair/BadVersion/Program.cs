namespace BadVersion;

internal class Program
{
    static void Main(string[] args)
    {
        var motorcycle = new Vehicle("Motorcycle", "AP123BC", "John Doe",
        new List<string> { "Замена тормозных колодок", "Замена масла" });

        var lorry = new Vehicle("Lorry", "AA456DY", "Та самая собака из казика",
        new List<string> { "Диагностика" });

        var car = new Vehicle("Car", "AT4146IH", "Peter Griffin",
        new List<string> { "Диагностика", "Замена масла", "Замена тормозных колодок" });

        var car2 = new Vehicle("Car", "AT9812IH", "Lois Griffin",
        new List<string> { "Диагностика", "Замена масла" });

        var order1 = new Order(1, motorcycle,
        new List<string> { "Замена тормозных колодок", "Замена масла" });
        Console.WriteLine($"Заказ №{order1.Number}");
        order1.CompleteOrder();

        Console.WriteLine($"\nИтого: {order1.CountPrice()} грн");
        Console.WriteLine($"Время затрачено на работу: {order1.CountHoursToComplete()}\n");

        var order2 = new Order(2, car,
        new List<string> { "Диагностика", "Замена масла", "Замена тормозных колодок" });
        Console.WriteLine($"Заказ №{order2.Number}");
        order2.CompleteOrder();

        Console.WriteLine($"\nИтого: {order2.CountPrice()} грн");
        Console.WriteLine($"Время затрачено на работу: {order2.CountHoursToComplete()}");
    }
}