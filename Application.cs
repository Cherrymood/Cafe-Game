using System;
using System.Threading;
class Application
{
    private Cafe _cafe;
    private IPrint _printer;
    private int _dayIncome;
    private int _amountOrders;
    private Waiter _waiter;
    private Customer _customer;
    private VIPCustomer _vipCustomer;
    private Cashier _cashier;

    public Application()
    {
        _cafe = new Cafe(_waiter, _customer, _vipCustomer, new List<Dish>(), _cashier);
        _printer = new PrintOutMenue("Menue");
        _dayIncome = 0;
        _amountOrders = 5;
    }
    public void StartGame()
{
    int target = 0;

    for (int i = 0; i < _amountOrders; i++)
    {
        _printer.Print();
        string order = _cafe.HandleCustomer(i, ref target);

        if (order.ToLower() == "shutdown")
        {
            Console.WriteLine("Customer requested game shutdown. Shutting down...");
            return;
        }

        if (ShouldQuit())
        {
            Console.WriteLine("Quitting game...");
            return;
        }
    }

    EndGame(target);
}
    private bool ShouldQuit()
    {
        Console.WriteLine("Enter your order (or 'q' to quit): ");
        string quit = Console.ReadLine();

        return !(string.IsNullOrWhiteSpace(quit) || quit.ToLower() != "q");
    }
    private void EndGame(int target)
    {
        _dayIncome = target;
        Console.WriteLine($"Waiter: Thank you. Cafe earned {_dayIncome}.");
        Console.WriteLine("End Game");
    }
}
