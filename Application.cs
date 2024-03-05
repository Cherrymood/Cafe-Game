using System;using System;

class Application
{
    private Cafe _cafe;
    private IPrint _printer;
    private int _dayIncome;
    private int _amountOrders;

    public Application(Cafe cafe, IPrint printer, int amountOrders)
    {
        _cafe = cafe;
        _printer = printer;
        _dayIncome = 0;
        _amountOrders = amountOrders;
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
