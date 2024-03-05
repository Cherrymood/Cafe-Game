using System;
using System.Collections.Generic;

public class Customer : ICustomer
{
    private Random rn;
    private List<Dish> _menu;

    public Customer(List<Dish> menu)
    {
        rn = new Random();
        _menu = menu ?? new List<Dish>(); 
    }

    public Dish MakeOrders()
    {
        // Generate a random index to select a dish from the menu
        int randomIndex = rn.Next(0, _menu.Count);

        // Return the randomly selected dish
        return _menu[randomIndex];
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
