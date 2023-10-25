class Cafe
{
    private int _dayIncome;
    public int level;
    public int amountCustomers;
    public Customer customer;
    public Menu menu;

    public Cafe()
    {
        Console.WriteLine("Welcome to our Cafe");
        level = 1;
        menu = new Menu();
        customer = new Customer(); // Create a single customer instance
        amountCustomers = 3 + (level + 1);
        _dayIncome = level * 5;
    }

    public void StartGame()
    {
        int dayIncomeGame = 0;
        
        for (int i = 1; i <= amountCustomers; i++)
        {
            var customerOrder = customer.MakeOrder();
            dayIncomeGame += customer.Payment();
        }

        if (dayIncomeGame >= _dayIncome * amountCustomers)
        {
            Console.WriteLine("You win! Choose the next level");
        }
        else
        {
            Console.WriteLine("You lost!");
        }
    }
}
