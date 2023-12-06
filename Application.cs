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
            Console.Write($"Enter your order (or 'q' to quit): ");
            string order = _customer.MakeOrders();
            int orderCost = _cafe.OrderDishPrice(order);
            
            if (order == "q")
            {
                Console.Write($"Waiter: Thank you. Cafe earned {0}", _dayIncome);
                break;
            }
            if (orderCost == 0)
            {
                Console.Write($"Waiter: There is no such a dish in our menue");
            }

            int cookingTime = _cookingTime.OrderTime(order);
            int custWait = _customer.WaitingTime();

            if(cookingTime < custWait)
            {
                Console.Write($"Customer: Yes I can wait");
                _dayIncome += orderCost;
            }
            else
            {
                Console.Write($"Customer: No, Sorry. I am in a hurry. Bye");
                Console.Write($"Waiter: Thank you. Cafe earned {0}", _dayIncome);
                Console.Write($"----EndGame----");
                break;
            }
        }
    }
}

