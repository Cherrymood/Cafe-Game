
using System;
class Application
{
    private ICustomer _customer;
    private Cafe _cafe;
    private int _dayIncome;
    private Kitchen _kitchen;
    private int _amountOrders;

    public Application()
    {
        Console.WriteLine($"Receptionist: Welcome to our Cafe");
        _cafe = new Cafe();
        _kitchen = new Kitchen();
        _dayIncome = 0;
        _amountOrders = 5;
    }

     public void StartGame()
    {
        int target = 0;

        for (int i = 0; i < _amountOrders; i++)
        {
            _cafe.GiveMenue();
            HandleCustomer(i, ref target);
        }

        EndGame(target);
    }

    private void HandleCustomer(int orderIndex, ref int target)
    {
        _customer = (orderIndex % 2 == 0) ? new Customer() : new VIPCustomer();

        string order = _customer.MakeOrders(orderIndex);
        int billToPay = _cafe.GetConfirmation(_customer.WaitingTime(), _kitchen.OrderTime(order), order);

        if (billToPay == 0)
        {
            _dayIncome = target;
            Console.WriteLine($"Waiter: Thank you. Cafe earned {_dayIncome}.");
            Console.WriteLine("Next Customer");
            return;
        }

        target += _customer.PayBill(billToPay);

        if (orderIndex == _amountOrders - 1 || ShouldQuit())
        {
            EndGame(target);
        }
        else
        {
            Console.WriteLine("Next Customer");
        }
    }

    private bool ShouldQuit()
    {
        Console.WriteLine("Enter your order (or 'q' to quit): ");
        string quit = Console.ReadLine();
        return quit == "q";
    }

    private void EndGame(int target)
    {
        _dayIncome = target;
        Console.WriteLine($"Waiter: Thank you. Cafe earned {_dayIncome}.");
        Console.WriteLine("End Game");
    }
}