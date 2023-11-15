class Application
{
    private int _dayIncome;
    private int _level { get; private set; }
    private int _amountCustomers;
    private Customer _customer;
    private Kitchen _menu;
    private Cafe _cafe;

    public Application()
    {
        Console.WriteLine("Welcome to our Cafe");
        _level = 1;
        _menu = new Kitchen();
        _customer = new Customer();
        _amountCustomers = 3 + (_level + 1);
        _dayIncome = _level * 3;
        _amountCustomers = 3 + (_level + 1);
    }

    public void StartGame()
    {
        int dayIncomeGame = 0;

        for (int i = 1; i <= _amountCustomers; i++)
        {
            int orderCost = _customer.MakeOrder();
            _dayIncomeGame += _cafe.Payment(orderCost);
        }

        if (dayIncomeGame >= _dayIncome * _amountCustomers)
        {
            Console.WriteLine("You win! Proceed to the next level.");
            IncreaseLevel();
        }
        else
        {
            Console.WriteLine("You lost! You can try again at the current level.");
        }

        // After the game, prompt the user to exit or continue.
        Console.Write("Do you want to exit the game? (Y/N): ");
        string exitChoice = Console.ReadLine();
        
        if (exitChoice.Trim().Equals("Y", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Thanks for playing. Goodbye!");
            Environment.Exit(0); // Exit the application
        }
    }
}

