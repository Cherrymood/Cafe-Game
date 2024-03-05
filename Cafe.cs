public class Cafe : IHandleCustomer, IHandleOrder
{
    private readonly ITakeOrder _waiter;
    private readonly ICustomer _customer;
    private readonly ICustomer _vipCustomer;
    private readonly IOrderBill _cashier;
    private readonly IKitchen _kitchen;
    private readonly Queue<Dish> _orderQueue;
    private readonly Queue<ICustomer> _customerQueue;
    private readonly Random _rn;
    private int _dayIncome;

    public Cafe()
    {
        Console.WriteLine($"Welcome to our Cafe");
        _customer = new Customer();
        _vipCustomer = new VIPCustomer();
        _waiter = new Waiter();
        _cashier = new Cashier();
        _orderQueue = new Queue<Dish>();
        _customerQueue = new Queue<ICustomer>();
        _rn = new Random();
        _kitchen = new Kitchen();
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
            if (_orderQueue.Count > 0)
            {
                Dish order = _orderQueue.Dequeue();
                int cookingTime = _kitchen.CookingTime(order);

                if (cookingTime >= 0)
                {
                    Thread.Sleep(cookingTime * 1000); // Simulate cooking time
                    int bill = _cashier.OrderBill(order);

                    if (bill > 0 && _customerQueue.Count > 0)
                    {
                        var customer = _customerQueue.Dequeue();
                        _dayIncome += customer.PayBill(bill);
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
        }
    }