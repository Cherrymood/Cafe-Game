class Cafe
{
    private Kitchen _kitchen;
    private Waiter _waiter;
    private Customer _customer;
    private VIPCustomer _vipCustomer;
    private int _dayIncome;
    public Cafe()
    {
        _kitchen = new Kitchen();
        _waiter = new Waiter();
        _customer = new Customer();
        _vipCustomer = new VIPCustomer();
        _dayIncome = 0;
    }
    public int GetBill(int customerWaitTime, int kitchenCookingTime, string order)
    {
        Console.WriteLine($"Waiter: The time for cooking: {kitchenCookingTime} min.");

        if (customerWaitTime >= kitchenCookingTime)
        {
            int bill = _waiter.TakeOrder(order);
            return bill;
        }
        else
        {
            Console.WriteLine($"Waiter: Sorry, we cannot prepare your order in time. Bye!");
            return 0;
        }
    }
    public void HandleCustomer(int orderIndex, ref int target)
    {
        ICustomer customer = (orderIndex % 2 == 0) ? _customer : _vipCustomer;

        string order = customer.MakeOrders(orderIndex);
        int billToPay = GetBill(customer.WaitingTime(), _kitchen.GetOrderTime(order), order);

        if (billToPay == 0)
        {
            Console.WriteLine($"Waiter: Thank you. Cafe earned {_dayIncome}.");
            Console.WriteLine("---Next Customer---");
            return;
        }

        target += customer.PayBill(billToPay);
    }
}