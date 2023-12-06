class Application
{
    private Customer _customer;
    private Cafe _cafe;
    private int _dailyIncome;
    private Kitchen _prepareTime;

    public Application()
    {
        Console.WriteLine("Welcome to our Cafe");
        _customer = new Customer();
        _cafe = new Cafe();
        _prepareTime = new Kitchen();
    }

    public void StartGame()
    {
        while(true)
        {
            Console.Write("Enter your order (or 'q' to quit): ");
            string order = _customer.MakeOrders();

            if (order.ToLower() == "q")
            {
                Console.WriteLine("That's all. Thank you!");
                break;
            }

            int orderCost = _cafe.OrderDishPrice(order);

            if(orderCost == 0)
            {
                Console.WriteLine("There is no such a dish in menue. Please, try again");
                continue;
            }

            int prepareTime = _prepareTime.PreperingTime(order);
            int waitingTime = _customer.WaitTime();

            if (prepareTime > waitingTime)
            {
                Console.WriteLine("Sorry, but we cannot prepare in time your order");
                break;
            }
            else
            {
                Console.WriteLine("Here is your order! Have a good day!");
                _dailyIncome += orderCost;
            }

        }

        Console.WriteLine("Your dayly income: {0}", _dailyIncome);
    }
}

