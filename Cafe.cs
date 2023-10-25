class Cafe
{
    private int _dayIncome;
    public int level;
    public int amountCustomers;
    public Customer newCustomer;
    public Menue menue;

    public Cafe()
    {
        Console.WriteLine("Welcome to our Cafe");
        level = 1;
        menue = new Menue();
        newCustomer = new Customer();
        amountCustomers = 3 + (level + 1);
        _dayIncome = level * 5;
    }

    public void StartGame()
    {
        int dayIncomeGame = 0;
        
        for (int i = 1; i <= amountCustomers; i++)
        {
            var customerOrder = newCustomer.MakeOrder(menue);
            dayIncomeGame += newCustomer.Payment(customerOrder);
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