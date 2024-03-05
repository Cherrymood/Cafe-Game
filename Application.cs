class Application
{
    private readonly Cafe _cafe;
    private readonly IPrint _printer;
    private int _dayIncome;
    private int _amountOrders;
    private readonly Random _rn;

    public Application()
    {
        _cafe = new Cafe();
        _printer = new PrintOutMenue("Menue");
        _dayIncome = 0;
        _rn = new Random();
        _amountOrders = _rn.Next(0, 20);
    }

    public void StartGame()
    {
        for (int i = 0; i < _amountOrders; i++)
        {
            _printer.Print();
            _cafe.HandleCustomer();
            _cafe.HandleOrder();

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
