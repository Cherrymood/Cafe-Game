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

        var customerOrderQ = new Queue<ICustomer>(customerQ);

        var orderQ = _cafe.HandleCustomer( customerOrderQ, _rn, _menu, _waiter, _printer);

        while(orderQ.Count > 0 && customerQ.Count > 0)
        {
            var client = customerQ.Dequeue();
            var newOrder = orderQ.Dequeue();

            var permit = _cafe.KitchenHandleOrder(newOrder, _kitchen, client, _rn);

            if(permit)
            {
                _dayIncome += _cafe.CashierHandleOrder(newOrder, _cashier, client);
            }

        }

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
