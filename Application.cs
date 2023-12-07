class Application
{
    private Customer _customer;
    private Cafe _cafe;
    private int _dayIncome;
    private Kitchen _kitchen;

    public Application()
    {
        Console.WriteLine($"Receptionist: Welcome to our Cafe");
        _cafe = new Cafe();
        _customer = new Customer();
        _kitchen = new Kitchen();
        _dayIncome = 0;
    }

    public void StartGame()
    {
        while(true)
        {
            Console.WriteLine($"Enter your order (or 'q' to quit): ");
            string quit = Console.ReadLine();
            if (quit == "q")
            {
                Console.WriteLine($"Waiter: Thank you. Cafe earned {0}", _dayIncome);
                break;
            }
            
            string order = _customer.MakeOrders(_cafe.GiveMenue());
            int billToPay = _cafe.GetConfirmation(_customer.WaitingTime(), _kitchen.OrderTime(order),order);
            
            if (billToPay == 0)
            {
                Console.WriteLine($"Waiter: Thank you. Cafe earned {0}", _dayIncome);
                break;
            }

            _dayIncome += _customer.PayBill(billToPay);
            
            Console.WriteLine($"Waiter: Thank you. Cafe earned {0}", _dayIncome);
        }
    }
}

