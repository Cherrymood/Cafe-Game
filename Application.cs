class Application
{
    private readonly Cafe _cafe;
    private readonly IPrint _printer;
    private readonly ITakeOrder _waiter;
    private readonly ICustomer _customer;
    private readonly ICustomer _vipCustomer;
    private readonly IOrderBill _cashier;
    private readonly IKitchen _kitchen;
    private readonly Queue<Dish> _orderQueue;
    private readonly Queue<ICustomer> _customerQueue;
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
        _orderQueue = new Queue<Dish>();
        _customerQueue = new Queue<ICustomer>();
        _getMenu = new DataAccess();
        _menu = _getMenu.GetMenu();
        _rn = new Random();
        _kitchen = new Kitchen();
        _dayIncome = 0;
    }

    public void StartGame()
    {
        for (int i = 0; i < _amountOrders; i++)
        {
            _printer.Print(_menu);
            _cafe.HandleCustomer(_rn, _menu, _customer, _waiter, _customerQueue, _vipCustomer, _orderQueue);
            _dayIncome += _cafe.HandleOrder(_menu, _orderQueue, _kitchen, _cashier, _customerQueue);

            if (ShouldQuit())
            {
                Console.WriteLine("Quitting game...");
                return;
            }
        }
        EndGame(_dayIncome);
    }

    private bool ShouldQuit()
    {
        Console.WriteLine("Enter your order (or 'q' to quit): ");
        string quit = Console.ReadLine()?.ToLower().Trim();

        return quit == "q";
    }

    private void EndGame(int target)
    {
        _dayIncome = target;
        Console.WriteLine($"Waiter: Thank you. Cafe earned {_dayIncome}.");
        Console.WriteLine("End Game");
    }
}
