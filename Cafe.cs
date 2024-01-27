class Cafe
{
    private Kitchen _kitchen;
    private Menue _menue;
    private Waiter _waiter;
    private Customer _customer;
    private VIPCustomer _vipCustomer;
    private Cafe _cafe;
    private int _dayIncome;

    public Cafe()
    {
        _cafe = new Cafe();
        _kitchen = new Kitchen();
        _menue = new Menue();
        _waiter = new Waiter();
        _customer = new Customer();
        _vipCustomer = new VIPCustomer();
        _dayIncome = 0;
    }
    public int GetConfirmation(int customerWaitTime, int kitchenCookingTime, string order)
    {
        Console.WriteLine($"Waiter: The time for cooking: {kitchenCookingTime} min.");
        if(customerWaitTime >= kitchenCookingTime)
        {
            string cookedMeal = _kitchen.Confirmation(order);
            int bill = _waiter.TakeOrder(cookedMeal);
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
        ICustomer customer;

        if (orderIndex % 2 == 0)
        {
            customer = _customer;
        }
        else
        {
            customer = _vipCustomer;
        }

        string order = customer.MakeOrders(orderIndex);
        int billToPay = GetConfirmation(customer.WaitingTime(), _kitchen.OrderTime(order), order);

        if (billToPay == 0)
        {
            Console.WriteLine($"Waiter: Thank you. Cafe earned {_dayIncome}.");
            Console.WriteLine("---Next Customer---");
            return;
        }

        target += customer.PayBill(billToPay);
    }
}