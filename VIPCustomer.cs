using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class VIPCustomer : ICustomer
{
    private Random rn;
    private List<Dish> _menu;

    public VIPCustomer(List<Dish> menu)
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
        Console.WriteLine($"VIP Customer: I cannot wait more than {waitTime} min.");
        return waitTime;
    }
    public int PayBill(int bill)
{
    int vipBill = (int)Math.Round(bill - bill * 0.2);
    Console.WriteLine($"VIP Customer: Here is your {vipBill} doll.");
    return vipBill;
}
}
