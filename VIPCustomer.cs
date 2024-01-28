using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class VIPCustomer : ICustomer
{
    private Random rn;
    private Menue _menue;

    public VIPCustomer()
    {
        rn = new Random();
        _menue = new Menue();
    }

    public string MakeOrders(int orderIndex)
{
    string order = null;
    var menue = _menue.GetMenue();

    while (string.IsNullOrEmpty(order) || !menue.ContainsKey(order))
    {
        Console.WriteLine($"Customer {orderIndex + 1}: Enter your order (or 'q' to quit): ");
        order = Console.ReadLine().Trim().ToLower();

        if (string.IsNullOrEmpty(order))
        {
            Console.WriteLine("Invalid input. Please try again.");
        }
        else if (!menue.ContainsKey(order) && order != "q")
        {
            Console.WriteLine($"Invalid order: {order}. Please choose a valid item from the menu.");
            return MakeOrders(orderIndex);
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

    public int WaitingTime()
    {
        int waitTime = rn.Next(0, 16);
        Console.WriteLine($"VIP Customer: I cannot wait more than {waitTime} min.");
        return waitTime;
    }

    public int PayBill(int bill)
    {
        Console.WriteLine($"VIP Customer: Here is your {bill} doll.");
        return bill;
    }
}
