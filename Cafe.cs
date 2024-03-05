using System;
using System.Collections.Generic;

public class Cafe : ICafe
{
    private readonly IOrderHandler _waiter;
    private readonly ICustomer _customer;
    private readonly ICustomer _vipCustomer;
    private readonly IOrderBill _cashier;
    private readonly List<Dish> _menuItems;
    private int _dayIncome;

    public Cafe(IOrderHandler waiter, ICustomer customer, ICustomer vipCustomer, List<Dish> menuItems, IOrderBill cashier)
    {
        _waiter = waiter;
        _cashier = cashier;
        _customer = customer;
        _vipCustomer = vipCustomer;
        _menuItems = menuItems;
        _dayIncome = 0;
    }

    public int GetBill(int customerWaitTime, string order)
    {
        Dish selectedDish = _menuItems.Find(dish => dish.DishName.ToLower() == order.ToLower());

        if (selectedDish == null)
        {
            Console.WriteLine($"Waiter: Sorry, {order} is not in our menu.");
            return 0;
        }

        int? cookingTimeNullable = selectedDish.PrepareTime;
        int cookingTime = cookingTimeNullable ?? 0;


        Console.WriteLine($"Waiter: The cooking time for {order}: {cookingTime} min.");

        if (customerWaitTime >= cookingTime)
        {
            int bill = _waiter.TakeOrder(order);
            return bill;
        }
        else
        {
            Console.WriteLine($"Waiter: Sorry, we cannot prepare your order in time. Bye!");
            return 0;
        }
    }

    public string HandleCustomer(int orderIndex, ref int target)
    {
        ICustomer customer = (orderIndex % 2 == 0) ? _customer : _vipCustomer;

        string order = customer.MakeOrders(orderIndex);

        if (order.ToLower() == "q")
        {
            Console.WriteLine("Customer decided to quit.");
            return "q";
        }

        int billToPay = GetBill(customer.WaitingTime(), order);

        if (billToPay == 0)
        {
            Console.WriteLine($"Waiter: Thank you. Cafe earned {_dayIncome}.");
            Console.WriteLine("---Next Customer---");
            return "";
        }

        target += customer.PayBill(billToPay);

        return order;
    }
}