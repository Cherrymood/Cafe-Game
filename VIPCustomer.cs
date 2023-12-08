using System.Runtime.Intrinsics.Arm;

public class VIPCustomer: ICustomer
{
    private Random rn;
    public VIPCustomer()
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
        Console.WriteLine($"VIPCustomer: I want {order}, please.");
        return order;
    }

    public int WaitingTime()
    {
        int waitTime = rn.Next(0, 16);
        Console.WriteLine($"VIPCustomer: I can not wait more than {waitTime} min.");
        return waitTime;
    }

    public int PayBill(int bill)
    {
        bill = Convert.ToInt32(bill - bill*0.2); 
        Console.WriteLine($"VIPCustomer: Here is your {bill} doll.");
        return bill;
    }
}