class Application
{
    private Customer _customer;
    private Cafe _cafe;
    private int _dayIncome;
    private Kitchen _kitchen;
    private int _amountOrders;

    public Application()
    {
        Console.WriteLine($"Receptionist: Welcome to our Cafe");
        _cafe = new Cafe();
        _customer = new Customer();
        _kitchen = new Kitchen();
        _dayIncome = 0;
        _amountOrders = 5;
    }

    public void StartGame()
    {
        for(int i = 0; i < _amountOrders; i++)
        {
            Dictionary<string, int> menue = _cafe.GiveMenue();
            string order = _customer.MakeOrders(menue);
            int billToPay = _cafe.GetConfirmation(_customer.WaitingTime(), _kitchen.OrderTime(order),order);
            
            if (billToPay == 0)
            {
                Console.WriteLine($"Waiter: Thank you. Cafe earned {_dayIncome}");
                continue;
            }

            _dayIncome += _customer.PayBill(billToPay);

            if(i == 4)
            {
                Console.WriteLine($"Waiter: Thank you. Cafe earned {_dayIncome}");
                break;
            }

            Console.WriteLine($"Enter your order (or 'q' to quit): ");
            string quit = Console.ReadLine();

            if (quit == "q")
            {
                Console.WriteLine($"Waiter: Thank you. Cafe earned {_dayIncome}");
                break;
            }
        }
    }
}

