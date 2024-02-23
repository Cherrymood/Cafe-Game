using System;

public class Waiter : IOrderHandler
{
    private string connectionString;
    private DataAccess _db;

    public Waiter()
    {
        _db = new DataAccess(connectionString);
    }

    public int TakeOrder(string order)
    {
        Console.WriteLine("Waiter: Hello, How are you? Here is our menu");

        var menuItems = _db.GetMenu();

        if (string.IsNullOrEmpty(order))
        {
            Console.WriteLine("Waiter: Invalid order. Please try again.");
            return 0;
        }

        foreach (var item in menuItems)
        {
            if (item.DishName.ToLower() == order.ToLower())
            {
                Console.WriteLine($"Waiter: Ordered {item.DishName}. The price: {item.Price} doll.");
                return item.Price;
            }
        }

        Console.WriteLine($"Waiter: {order} is not in our menu.");
        return 0;
    }
}
