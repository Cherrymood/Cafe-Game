using System;
using System.Collections.Generic;

public class Customer : ICustomer
{
    private Random rn;
    private List<Dish> _menu;

    public Customer(List<Dish> menu)
    {
        rn = new Random();
        _menu = menu;
    }

    public string MakeOrders(int orderIndex)
    {
        string order = null;

        while (string.IsNullOrEmpty(order) || !IsValidOrder(order))
        {
            Console.WriteLine($"Customer {orderIndex + 1}: Enter your order (or 'q' to quit): ");
            order = Console.ReadLine().Trim().ToLower();

            if (string.IsNullOrEmpty(order))
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
            else if (!IsValidOrder(order) && order != "q")
            {
                Console.WriteLine($"Invalid order: {order}. Please choose a valid item from the menu.");
            }
            else if (order == "shutdown")
            {
                Console.WriteLine("Shutting down the game as requested by the customer.");
                return "shutdown";
            }
            else
            {
                Console.WriteLine($"Customer: I want {order}, please.");
            }
        }
        return order;
    }

    private bool IsValidOrder(string order)
    {
        foreach (var dish in _menu)
        {
            if (dish.DishName.ToLower() == order)
            {
                return true;
            }
        }
        return false;
    }

    public int WaitingTime()
    {
        int waitTime = rn.Next(0, 16);
        
        Console.WriteLine($"Customer: I cannot wait more than {waitTime} min.");

        return waitTime;
    }

    public int PayBill(int bill)
    {
        Console.WriteLine($"Customer: Here is your {bill} doll.");
        return bill;
    }
}
