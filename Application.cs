class Application
{
    private Customer _customer;
    private Cafe _cafe;
    private int _dayIncome;
    private Kitchen _cookingTime;

    public Application()
    {
        Console.WriteLine("Welcome to our Cafe");
        _cafe = new Cafe();
        _customer = new Customer();
        _dayIncome = 0;
        _cookingTime = new Kitchen();
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

            int cookingTime = _cookingTime.OrderTime(order);
            int custWait = _customer.WaitingTime();
            if(cookingTime < custWait)
            {
                Console.Write("Yes I can wait");
                _dayIncome += orderCost;
            }
            else
            {
                Console.Write("No, Sorry. I am in a hurry. Bye");
                Console.Write(_dayIncome);
                Console.Write("EndGame");
                break;
            }
        }
    }
}

