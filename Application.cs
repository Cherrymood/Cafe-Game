class Application
{
    private Customer _customer;
    private Cafe _cafe;
    private int _dayIncome;

    public Application()
    {
        Console.WriteLine("Welcome to our Cafe");
        _cafe = new Cafe();
        _customer = new Customer();
        _dayIncome = 0;
    }

    public void StartGame()
    {
        while(true)
        {
            Console.Write("Enter your order (or 'q' to quit): ");
            string order = _customer.MakeOrders();
            int orderCost = _cafe.OrderDishPrice(order);
            
            if (order == "q")
            {
                Console.Write("Thank you.");
                Console.Write(_dayIncome);
                break;
            }
            if (orderCost == 0)
            {
                Console.Write("There is no such a dish in our menue");
            }

            _dayIncome += orderCost;
        }
    }
}

