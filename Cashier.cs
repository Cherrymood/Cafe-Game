using System;

public class Cashier : IOrderBill
{
    private readonly IOrderHandler _waiter;

    public Cashier(IOrderHandler waiter)
    {
        _waiter = waiter;
    }

    public int OrderBill(string order)
    {
        int billAmount = _waiter.TakeOrder(order);

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