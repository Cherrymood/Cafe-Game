public class Cafe: IHandleCustomer, IHandleOrder
{
    public Cafe()
    {
        Console.WriteLine($"Welcome to our Cafe");
    }
    public Queue<Dish> HandleCustomer(Queue<ICustomer> customerQueue, Random rn, List<Dish> menu, ICustomer customer, ITakeOrder waiter, ICustomer vipCustomer, PrintOutMenue _printer, int _amountOrders)
    {
        int index = rn.Next(0, 100);
        
        Queue<Dish> orderQueue = new Queue<Dish>();

        for(int i = 0; i < _amountOrders; i++){

            if (index % 2 == 0)
            {
                customer = customer; // Assign regular customer
            }
            else
            {
                customer = vipCustomer; // Assign VIP customer
            }

            customerQueue.Enqueue(customer);
        }

        while(customerQueue.Count > 0)
        {
            var cust = customerQueue.Dequeue();

            Dish order = cust.MakeOrders(rn, menu);

            waiter.TakeOrder(order, orderQueue, _printer, menu);

            customerQueue.Enqueue(cust);

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