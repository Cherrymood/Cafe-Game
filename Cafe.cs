class Cafe
{
    private int _dayIncome;
    private int _level;
    private int _amountCustomers;
    private bool _completeLevel;
    private Customer _customer;
    private Menue _menue;

    
    public Cafe(int level)
    {
        this._level = level;
        Console.WriteLine("Welcome to our Cafe");
        _amountCustomers = 3 + (level + 1);
        _dayIncome = level * 5;
        _menue = new Menue();
    }

    public void StartGame()
    {
        for (int i = 0; i <= _amountCustomers; i++)
        {
            dayIncomeGame = 0;
            
            _customer = new Customer();
            var customerOrder = _customer.MakeOrder(_menue);
            _dayIncome += _customer.Payment(customerOrder);
        }

        if (dayIncomeGame >= _dayIncome)
        {
            Console.WriteLine("You win!");
        }
        else
        {
            Console.WriteLine("You lost!");
        }
    }
}