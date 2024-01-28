class Waiter : IOrderHandler
{
    private Menue _menue;

    public Waiter()
    {
        _menue = new Menue();
    }
    public int TakeOrder(string order)
    {
        Console.WriteLine($"Waiter: Hello, How are you? Here is our menue");

        var menu = _menue.GetMenue();

        if (menu.ContainsKey(order))
        {
            int price = menu[order];
            Console.WriteLine($"Waiter: Ordered {order}. The price: {price} doll.");
            return price;
        }
        else
        {
            Console.WriteLine($"Waiter: {order} is not in our menu.");
            return 0;
        }
    }

}