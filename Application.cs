class Application
{
    private readonly Cafe _cafe;
    private readonly PrintOutMenue _printer;
    private readonly ITakeOrder _waiter;
    private readonly ICustomer _customer;
    private readonly ICustomer _vipCustomer;
    private readonly IOrderBill _cashier;
    private readonly IKitchen _kitchen;
    private readonly DataAccess _getMenu;
    private readonly List<Dish> _menu;
    private readonly Random _rn;
    private int _dayIncome;
    private int _amountOrders;

    public Application()
    {
        _cafe = new Cafe();
        _customer = new Customer();
        _vipCustomer = new VIPCustomer();
        _waiter = new Waiter();
        _cashier = new Cashier();
        _getMenu = new DataAccess();
        _menu = _getMenu.GetMenu();
        _rn = new Random();
        _kitchen = new Kitchen();
        _amountOrders = _rn.Next(5, 10);
        _dayIncome = 0;
        _printer = new PrintOutMenue();
    }

    public void StartGame()
    {
        var customerQ = _cafe.CustomerQueue ( _customer, _vipCustomer, _rn, _amountOrders);

        var orderQ = _cafe.HandleCustomer( customerQ, _rn, _menu, _waiter, _printer);

        _dayIncome += _cafe.HandleOrder(_menu, orderQ, _kitchen, _cashier, customerQ, _rn);

        EndGame(_dayIncome);

        Quit();
    }

    private void EndGame(int target)
    {
        _dayIncome = target;
        Console.WriteLine($"Waiter: Thank you. Cafe earned {_dayIncome}.");
        Console.WriteLine("End Game");
    }

    public void Quit()
    {
        Console.WriteLine("Quitting the application...");
        Environment.Exit(0); // Exit the application with a success code
    }
}
