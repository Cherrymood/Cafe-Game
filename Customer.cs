using System.Runtime.Intrinsics.Arm;

public class Customer
{
    private Random rn;
    public Customer()
    {
        Console.WriteLine($"Customer: Thank you");
        rn = new Random();
    }
    public string MakeOrders()
    {
        Console.Write($"Waiter: Enter your order: ");
            

        string order = Console.ReadLine();
        
        if (!string.IsNullOrWhiteSpace(order))
            
            {
                return order;
            }
        else
            {
                Console.WriteLine("Waiter: Invalid order. Please enter a valid order.");
                return MakeOrders();
            }
    }

    public int WaitingTime()
    {
        int waitTime = rn.Next(0, 15);

        return waitTime;
    }
}