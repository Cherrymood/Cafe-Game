using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class Cafe : ICafe
{
    private readonly ITakeOrder _waiter;
    private readonly ICustomer _customer;
    private readonly ICustomer _vipCustomer;
    private readonly IOrderBill _cashier;
    private readonly IKitchen _kitchen;
    private Random _rn;
    private Queue<Dish> _orderQueue;
    private Queue<ICustomer> _customerQueue;
    private int _dayIncome;

    public Cafe(ITakeOrder waiter, ICustomer customer, ICustomer vipCustomer, IOrderBill cashier, Queue<Dish> orderQueue, Random rn, IKitchen kitchen, Queue<ICustomer> customerQueue)
    {
        Console.WriteLine($"Welcome to our Cafe");
        _customer = customer;
        _waiter = waiter;
        _cashier = cashier;
        _customer = customer;
        _vipCustomer = vipCustomer;
        _kitchen = kitchen;
        _orderQueue = orderQueue;
        _customerQueue = customerQueue;
        _rn = rn;
        _dayIncome = 0;
    }
    public void HandleCustomer()
    {
        ICustomer customer;

        int index = _rn.Next(0, 100);

        if (index % 2 == 0)
        {
            customer = _customer; // Assign regular customer
        }
        else
        {
            customer = _vipCustomer; // Assign VIP customer
        }

        Dish order = customer.MakeOrders();

        int customerWaiting = customer.WaitingTime();

        if(customerWaiting >= order.PrepareTime)
        {
            _waiter.TakeOrder(order, _orderQueue);

            _customerQueue.Enqueue(customer);

            Console.WriteLine($"Waiter: You will get your order in time!");
        }
    }

    public void HandleOrder()
    {
        Dish order = _orderQueue.Dequeue();

        _kitchen.CookingTime(order);

        int bill = _cashier.OrderBill(order);

        var customer = _customerQueue.Dequeue();

        _dayIncome += customer.PayBill(bill);
    }
}