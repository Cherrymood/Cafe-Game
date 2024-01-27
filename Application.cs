using System;

class Application
{
    private ICustomer _customer;
    private Cafe _cafe;
    private Kitchen _kitchen;
    private PrintOutMenue _printer;
    private int _dayIncome;
    private int _amountOrders;

    public Application()
    {
        Console.WriteLine($"Receptionist: Welcome to our Cafe");
        _cafe = new Cafe();
        _kitchen = new Kitchen();
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
        }

        EndGame(target);
    }

    public bool ShouldQuit()
    {
        Console.WriteLine("Enter your order (or 'q' to quit): ");

        string quit = Console.ReadLine();

        if (string.IsNullOrEmpty(quit))
        {
            Console.WriteLine("Invalid input. Please try again.");
            return ShouldQuit();
        }

        return quit.ToLower() == "q";
    }

    public void EndGame(int target)
    {
        _dayIncome = target;
        Console.WriteLine($"Waiter: Thank you. Cafe earned {_dayIncome}.");
        Console.WriteLine("End Game");
    }
}
