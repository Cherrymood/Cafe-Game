using System;
using System.Collections.Generic;

public class Waiter : IOrderHandler, IOrderBill
{
    private DataAccess _db;
    private List<Dish> _menuItems;

    public Waiter(DataAccess db)
    {
        _db = db;
        _menuItems = _db.GetMenu();
    }

    public int TakeOrder(string order)
    {
        Console.WriteLine("Waiter: Hello, How are you? Here is our menu");

        if (string.IsNullOrEmpty(order))
        {
            Console.WriteLine("Waiter: Invalid order. Please try again.");
            return 0;
        }

        foreach (var item in _menuItems)
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

    public int OrderBill(string order)
    {
        var orderBill = 0;

        foreach (var item in _menuItems)
        {
            if (item.DishName.ToLower() == order.ToLower())
            {
                orderBill = item.Price;
                break;
            }
        }

        Console.WriteLine($"VIP Customer: Here is your {orderBill} doll.");
        return orderBill;
    }
}
