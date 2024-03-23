public class Cafe: IHandleCustomer, IHandleOrder
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

    public int HandleOrder(List<Dish> menu, Queue<Dish> orderQueue, IKitchen kitchen, IOrderBill cashier, Queue<ICustomer> customerQueue, Random rn)
        {
            
            int income = 0;

            while (orderQueue.Count > 0)
            {
                Dish order = orderQueue.Dequeue();

                int cookingTime = kitchen.CookingTime(order);

                var client = customerQueue.Dequeue();

                var clientWaiting = client.WaitingTime(rn);

                if(clientWaiting < cookingTime)
                {
                    return 0;
                }

                else
                {
                    int bill = cashier.OrderBill(order);

                    income += client.PayBill(bill);
                }
            }
            return income;
        }
    }