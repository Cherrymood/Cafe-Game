class Cafe
{
    private int _dayIncome;
    public int Level { get; private set; } // Add a Level property
    public int AmountCustomers;
    public Customer Customer;
    public Menu Menu;

    public Cafe()
    {
        Console.WriteLine("Welcome to our Cafe");
        Level = 1; // Start at level 1
        Menu = new Menu();
        Customer = new Customer();
        AmountCustomers = 3 + (Level + 1);
        _dayIncome = Level * 3;
    }

    // Method to increase the level
    public void IncreaseLevel()
    {
        Level++; // Increment the level
        AmountCustomers = 3 + (Level + 1); // Adjust the number of customers based on the new level
        _dayIncome = Level * 3; // Adjust the income goal based on the new level
    }

    public void StartGame()
    {
        int dayIncomeGame = 0;

        for (int i = 1; i <= AmountCustomers; i++)
        {
            Customer.MakeOrder();
            dayIncomeGame += Customer.Payment();
        }

        if (dayIncomeGame >= _dayIncome * AmountCustomers)
        {
            Console.WriteLine("You win! Proceed to the next level.");
            IncreaseLevel(); // Increase the level
        }
        else
        {
            Console.WriteLine("You lost! You can try again at the current level.");
        }
    }

}
