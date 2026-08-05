namespace BadVersion;

internal class Order
{
    public int Number;
    public Vehicle Vehicle;
    public List<string> ServiceNames;

    public Order(int number, Vehicle vehicle, List<string> serviceNames)
    {
        Number = number;
        Vehicle = vehicle;
        ServiceNames = serviceNames;
    }

    public decimal CountPrice()
    {
        decimal total = 0;

        foreach (var serviceName in ServiceNames)
        {
            switch (serviceName)
            {
                case "Замена тормозных колодок":
                    total += 5000;
                    break;
                case "Диагностика":
                    total += 2000;
                    break;
                case "Замена масла":
                    total += 3000;
                    break;
                default:
                    throw new Exception("Неизвестная услуга: " + serviceName);
            }
        }
        return total;
    }

    public TimeSpan CountHoursToComplete()
    {
        TimeSpan total = TimeSpan.Zero;

        foreach (var serviceName in ServiceNames)
        {
            switch (serviceName)
            {
                case "Замена тормозных колодок":
                    total += TimeSpan.FromHours(2);
                    break;
                case "Диагностика":
                    total += TimeSpan.FromHours(3);
                    break;
                case "Замена масла":
                    total += TimeSpan.FromHours(1);
                    break;
                default:
                    throw new Exception();
            }
        }
        return total;
    }

    public void CompleteOrder()
    {
        foreach (var serviceName in ServiceNames)
        {
            if (serviceName == "Замена тормозных колодок")
            {
                Vehicle.Problems.Remove(serviceName);
                Console.WriteLine($"Тормоза поменяны у т.с. {Vehicle.Number}");
                Console.WriteLine($"Стоимость: 5000 грн.");
            }
            else if (serviceName == "Диагностика")
            {
                Vehicle.Problems.Remove(serviceName);
                Console.WriteLine($"Диагностика проведена у т.с. {Vehicle.Number}");
                Console.WriteLine($"Стоимость: 2000 грн.");
            }
            else if (serviceName == "Замена масла")
            {
                Vehicle.Problems.Remove(serviceName);
                Console.WriteLine($"Масло заменено у т.с. {Vehicle.Number}");
                Console.WriteLine($"Стоимость: 3000 грн.");
            }
            else
            {
                throw new Exception();
            }
        }
    }
}