using System;

public class Cashier : IOrderBill
{
    private Waiter _waiter;

    public Cashier(Waiter waiter)
    {
        _waiter = waiter;
    }

    public int OrderBill(string order)
    {
        int billAmount = _waiter.TakeOrder();

        if (billAmount > 0)
        {
            Console.WriteLine($"Cashier: Your bill amount is {billAmount} dollars.");
            return billAmount;
        }
        else
        {
            Console.WriteLine($"Cashier: Sorry, {order} is not in our menu.");
            return 0;
        }
    }
}