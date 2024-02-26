using System;
using System.Collections.Generic;

public class Waiter : IOrderHandler, IOrderBill
{
    private readonly List<Dish> _menuItems;

    public Waiter(List<Dish> menuItems)
    {
        _menuItems = menuItems;
    }

    public int TakeOrder(string order)
    {
        Console.WriteLine("Waiter: Hello, How are you? Here is our menu");

        if (string.IsNullOrEmpty(order))
        {
            Console.WriteLine("Waiter: Invalid order. Please try again.");
            return 0;
        }

        var menuItem = _menuItems.Find(item => item.DishName.ToLower() == order.ToLower());

        if (menuItem != null)
        {
            Console.WriteLine($"Waiter: Ordered {menuItem.DishName}. The price: {menuItem.Price} doll.");
            return menuItem.Price ?? throw new InvalidOperationException("Nullable integer is null.");;
        }
        else
        {
            Console.WriteLine($"Waiter: {order} is not in our menu.");
            return 0;
        }
    }

    public int OrderBill(string order)
    {
        var menuItem = _menuItems.Find(item => item.DishName.ToLower() == order.ToLower());

        if (menuItem != null)
        {
            Console.WriteLine($"VIP Customer: Here is your {menuItem.Price} doll.");
            return menuItem.Price ?? throw new InvalidOperationException("Nullable integer is null.");;
        }
        else
        {
            Console.WriteLine($"VIP Customer: Sorry, {order} is not in our menu.");
            return 0;
        }
    }
}
