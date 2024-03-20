public class Cafe: IHandleCustomer, IHandleOrder
{
    public Cafe()
    {
        Console.WriteLine($"Welcome to our Cafe");
    }
    public void HandleCustomer(Random rn, List<Dish> menu, ICustomer customer, ITakeOrder waiter, Queue<ICustomer> customerQueue, ICustomer vipCustomer, Queue<Dish> orderQueue)
    {
        int index = rn.Next(0, 100);

        if (index % 2 == 0)
        {
            customer = customer; // Assign regular customer
        }
        else
        {
            customer = vipCustomer; // Assign VIP customer
        }

        Dish order = customer.MakeOrders(rn, menu);

        int customerWaiting = customer.WaitingTime(rn);

        if(customerWaiting >= order.PrepareTime)
        {
            waiter.TakeOrder(order, orderQueue);

            customerQueue.Enqueue(customer);

            Console.WriteLine($"Waiter: You will get your order in time!");
        }
    }
    public int HandleOrder(List<Dish> menu, Queue<Dish> orderQueue, IKitchen kitchen, IOrderBill cashier, Queue<ICustomer> customerQueue)
        {
            
            int income = 0;

            if (orderQueue.Count > 0)
            {
                Dish order = orderQueue.Dequeue();
                int cookingTime = kitchen.CookingTime(order);

                if (cookingTime >= 0)
                {
                    Thread.Sleep(cookingTime * 1000); // Simulate cooking time
                    int bill = cashier.OrderBill(order);

                    if (bill > 0 && customerQueue.Count > 0)
                    {
                        var customer = customerQueue.Dequeue();
                        income += customer.PayBill(bill);
                    }
                }
                else
                {
                    Console.WriteLine("Error: Invalid cooking time");
                }
            }
            else
            {
                Console.WriteLine("No orders to handle");
            }
            return income;
        }
    }