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
        Console.WriteLine($"VIP Customer: I cannot wait more than {waitTime} min.");
        return waitTime;
    }
    public int PayBill(int bill)
{
    int vipBill = (int)Math.Round(bill - bill * 0.2);

    return vipBill;
}
}
