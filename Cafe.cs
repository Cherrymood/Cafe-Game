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

    public void StartGame(int level)
    {
        for (int i = 0; i <= amountCustomers; i++)
        {
            int dayIncomeGame = 0;
        
            var customerOrder = newCustomer.MakeOrder(menue);
            dayIncomeGame += newCustomer.Payment(customerOrder);
        }

        if (dayIncomeGame >= _dayIncome)
        {
            Console.WriteLine("You win! Choose next level");
        }
        else
        {
            Console.WriteLine("You lost!");
        }
    }
}