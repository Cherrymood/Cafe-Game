using System;
using System.Collections.Generic;

public class Cashier : IOrderBill
{
    private readonly List<Dish> _menuItems;

    public Cashier(List<Dish> menuItems)
    {
        _menuItems = menuItems;
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
