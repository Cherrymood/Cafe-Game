public class VIPCustomer : ICustomer
{
    private Random rn;

    public VIPCustomer()
    {
        rn = new Random();
    }

    public string MakeOrders(int orderIndex)
    {
        Console.WriteLine($"VIP Customer {orderIndex + 1}: Enter your VIP order (or 'q' to quit): ");
        return Console.ReadLine();
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
