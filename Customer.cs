using System.Runtime.Intrinsics.Arm;

public class Customer
{
    private Random rn;
    public Customer()
    {
        Console.WriteLine("Thank you");
        rn = new Random();
    }
    public string MakeOrders()
    {
        string order = Console.ReadLine();

        return order;
    }

    public int WaitingTime()
    {
        int waitTime = rn.Next(0, 15);

        return waitTime;
    }
}