using System;
using System.Collections.Generic;

public class Customer : ICustomer
{

    public Dish MakeOrders(Random rn, List<Dish> menu)
    {
        // Generate a random index to select a dish from the menu
        int randomIndex = rn.Next(0, menu.Count);

        Console.WriteLine($"Customer: Hello, I want to order{menu[randomIndex].DishName}, please");
        // Return the randomly selected dish
        return menu[randomIndex];
    }

    public int WaitingTime(Random rn)
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
