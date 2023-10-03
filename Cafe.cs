class Cafe
{
    private int _dayIncome;
    private int _level;
    private int _amountCustomers;
    private Customer _customer;
    private Menue _menue;

    
    public Cafe()
    {
        Console.WriteLine("Welcome to our Cafe");

        int level = 1;
        this._level = level;
        Menue menue = new Menue();
        this._menue = menue;
        Customer newCostomer = new Customer();
        this._customer = newCostomer;
        int amountCustomers = 3 + (level + 1)
        this._amountCustomers = amountCustomers;
        _dayIncome = level * 5;
    }

    public void StartGame(int level)
    {
        for (int i = 0; i <= amountCustomers; i++)
        {
            int dayIncomeGame = 0;
        
            var customerOrder = newCostomer.MakeOrder(menue);
            dayIncomeGame += newCostomer.Payment(customerOrder);
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