using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class VIPCustomer : ICustomer
{
    public VIPCustomer()
    {
        Console.WriteLine($"VIPCustomer: I am here and want to order.");
    }

    public Dish MakeOrders(Random rn, List<Dish> menu)
    {
        // Generate a random index to select a dish from the menu
        int randomIndex = rn.Next(0, menu.Count);
        int index = 0;
        Dish order = null;

        foreach(var dish in menu)
        {
            if(index == randomIndex)
            {
                return dish;
            }
        }

        // Return the randomly selected dish
        return order;
    }

    public int WaitingTime(Random rn)
    {
        int waitTime = rn.Next(0, 16);
        
        Console.WriteLine($"VIPCustomer: I cannot wait more than {waitTime} min.");

        return waitTime;
    }

    public int PayBill(int bill)
{
    int vipBill = (int)Math.Round(bill - bill * 0.2);

    return vipBill;
}
}
