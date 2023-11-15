class Application
{
    private int _dayIncome;
    private int Level { get; private set; }
    private int AmountCustomers;
    private Customer Customer;
    private Menu Menu;

    public Application()
    {
        Console.WriteLine("Welcome to our Cafe");
        Level = 1;
        Menu = new Menu();
        Customer = new Customer();
        AmountCustomers = 3 + (Level + 1);
        _dayIncome = Level * 3;
    }

    public void IncreaseLevel()
    {
        Level++;
        AmountCustomers = 3 + (Level + 1);
        _dayIncome = Level * 15;
    }

    public void StartGame()
    {
        int dayIncomeGame = 0;

        for (int i = 1; i <= AmountCustomers; i++)
        {
            int orderCost = Customer.MakeOrder();
            dayIncomeGame += Customer.Payment(orderCost);
        }

        if (dayIncomeGame >= _dayIncome * AmountCustomers)
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
