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
        int target = 0;

        for(int i = 0; i < _amountOrders; i++)
        {
            Dictionary<string, int> menue = _cafe.GiveMenue();
            string order = _customer.MakeOrders(menue);
            int billToPay = _cafe.GetConfirmation(_customer.WaitingTime(), _kitchen.OrderTime(order),order);
            
            if (billToPay == 0)
            {
                _dayIncome = target;
                Console.WriteLine($"Waiter: Thank you. Cafe earned {_dayIncome}.");
                Console.WriteLine($"-----Next customer-----");
                continue;
            }

            target += _customer.PayBill(billToPay);

            if(i == 4)
            {
                _dayIncome = target;
                Console.WriteLine($"Waiter: Thank you. Cafe earned {_dayIncome}.");
                Console.WriteLine($"---End game---");
                break;
            }

            Console.WriteLine($"-----Next customer-----");

            Console.WriteLine($"Enter your order (or 'q' to quit): ");
            string quit = Console.ReadLine();

            if (quit == "q")
            {
                _dayIncome = target;
                Console.WriteLine($"Waiter: Thank you. Cafe earned {_dayIncome}.");
                Console.WriteLine($"-----End game-----");
                break;
            }
        }
    }
}

