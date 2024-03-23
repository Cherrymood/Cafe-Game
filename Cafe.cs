public class Cafe: IHandleCustomer, IKitchenHandleOrder, ICustomerQueue, ICashierHandleOrder
{
    public Cafe()
    {
        Console.WriteLine($"Welcome to our Cafe");
    }

    public Queue<ICustomer> CustomerQueue (ICustomer customer, ICustomer vipCustomer, Random _rn, int _amountOrders)
    {
        
        var customerQueue = new Queue<ICustomer>();
        
        for (int i = 0; i < _amountOrders; i++)
        {
            // Decide whether to add a regular customer or a VIP customer
            ICustomer selectedCustomer = _rn.Next(0, 2) == 0 ? customer : vipCustomer;

            // Enqueue the selected customer
            customerQueue.Enqueue(selectedCustomer);
        }

        return customerQueue;
    }
    
    public Queue<Dish> HandleCustomer(Queue<ICustomer> customerQueue, Random rn, List<Dish> menu, ITakeOrder waiter, PrintOutMenue printer)

    {
        Queue<Dish> orderQueue = new Queue<Dish>();

        while (customerQueue.Count > 0)
        {
            var cust = customerQueue.Dequeue();

            Dish order = cust.MakeOrders(rn, menu);

            waiter.TakeOrder(order, orderQueue, printer, menu);

            Console.WriteLine("                                               ");
            Console.WriteLine("***********************************************");
            Console.WriteLine("                                               ");
        }

        return orderQueue;
    }

    public bool KitchenHandleOrder(Dish order, IKitchen kitchen, ICustomer customer, Random rn)
    {
        int cookingTime = kitchen.CookingTime(order);

        int clientWaiting = customer.WaitingTime(rn);

        if(clientWaiting < cookingTime)

        {
            return false;
        }

        return true;
    }

    public int CashierHandleOrder(Dish order, IOrderBill cashier, ICustomer customer)
    {
        int bill = cashier.OrderBill(order);

        return customer.PayBill(bill);
    }
}