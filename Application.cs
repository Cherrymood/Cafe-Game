class Application
{
    private Customer _customer;
    private Cafe _cafe;
    private int _dayIncome;
    private Kitchen _cookingTime;

    public Application()
    {
        Console.WriteLine($"Receptionist: Welcome to our Cafe");
        _cafe = new Cafe();
        _customer = new Customer();
        _dayIncome = 0;
        _cookingTime = new Kitchen();
    }

    public void StartGame()
    {
        while(true)
        {
            Console.WriteLine($"Enter your order (or 'q' to quit): ");
            
            string quit = Console.ReadLine();
            string order = _customer.MakeOrders(_cafe.GiveMenue());
            int orderCost = _cafe.OrderDishPrice(order);
            
            if (quit == "q")
            {
                Console.WriteLine($"Waiter: Thank you. Cafe earned {0}", _dayIncome);
                break;
            }

            int cookingTime = _cookingTime.OrderTime(order);
            int custWait = _customer.WaitingTime();

            if(cookingTime < custWait)
            {
                Console.WriteLine($"Customer: Yes I can wait");
                _dayIncome += orderCost;
            }
            else
            {
                Console.WriteLine($"Customer: No, Sorry. I am in a hurry. Bye");
                Console.WriteLine($"Waiter: Thank you. Cafe earned {0}", _dayIncome);
                Console.WriteLine($"----EndGame----");
                break;
            }
        }
    }
}

