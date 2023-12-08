using System.Runtime.Intrinsics.Arm;

public class Customer
{
    private Random rn;
    public Customer()
    {
        rn = new Random();
    }
    public string MakeOrders(Dictionary<string, int> menue)
    {
        string order = "";
        int choose = rn.Next(1, menue.Count+1);

        foreach(string key in menue.Keys)
        {
            if(choose == 0)
            {
                order += key;
            }
            choose--;
        }
        Console.WriteLine($"Customer: I want {order}");
        return order;
    }

    public int WaitingTime()
    {
        int waitTime = rn.Next(0, 16);

        return waitTime;
    }

    public int PayBill(int bill)
    {
        return bill;
    }
}