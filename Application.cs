class Application
{
    private Cafe _cafe;
    private PrintOutMenue _printer;
    private int _dayIncome;
    private int _amountOrders;

    public Application()
    {
        _cafe = new Cafe();
        _printer = new PrintOutMenue();
        _dayIncome = 0;
        _amountOrders = 5;
    }
    public void StartGame()
    {
        int target = 0;

        for (int i = 0; i < _amountOrders; i++)
        {
            _printer.Print();
            _cafe.HandleCustomer(i, ref target);
            
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
