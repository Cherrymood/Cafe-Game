using System;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;

public class Customer : ICustomer
{
    private Random rn;
    public Customer()
    {
        rn = new Random();
    }

    public string MakeOrders(int orderIndex)
{
    string order = null;

    while (string.IsNullOrEmpty(order))
    {
        Console.WriteLine($"Customer {orderIndex + 1}: Enter your order (or 'q' to quit): ");
        order = Console.ReadLine();

        if (string.IsNullOrEmpty(order))
        {
            Console.WriteLine("Invalid input. Please try again.");
        }
        else
        {
            Console.WriteLine($"Customer: I want {order}, please.");
        }
    }

    return order;
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
