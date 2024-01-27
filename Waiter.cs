class Waiter
{
    private Menue _menue;
    private Waiter _waiter;

    public Waiter()
    {
        _menue = new Menue();
        _waiter = new Waiter();
    }
    public int TakeOrder(string order)
    {
        Console.WriteLine($"Waiter: Hello, How are you? Here is our menue");

        var menue = _menue.GetMenue();
        int price = menue[order];

        if (price > 0)
        {
            Console.WriteLine($"Waiter: Ordered {order}. The price: {price} doll.");
        }
        else
        {
            Console.WriteLine($"Waiter: {order} is not in our menu.");
            return 0;
        }
      
        return price;
    }

}