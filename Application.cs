class Application
{
    private Customer _customer;
    private Cafe _cafe;
    private int _dailyIncome;

    public Application()
    {
        Console.WriteLine("Welcome to our Cafe");
        _customer = new Customer();
        _cafe = new Cafe();
    }

    public void StartGame()
    {
        while(true)
        {
            string order = _customer.MakeOrders();
            
            if (order.ToLower() == "q")
            {
                Console.WriteLine("That's all. Thank you!");
                break;
            }

            _dailyIncome += _cafe.OrderDishPrice(order);
        }

        Console.WriteLine("Your dayly income: {0}", _dailyIncome);
    }
}

