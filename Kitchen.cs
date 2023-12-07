class Kitchen{
   
    private Dictionary<string, int> timePrepare;
    private TimeSpan _cooking;
    public Kitchen()
    {
        timePrepare = new Dictionary<string, int>
        {
            {"soup", 10},
            {"meat", 15},
            {"snacks", 2},
            {"salad", 5},
            {"pizza", 12},
            {"water", 1},
            {"hot drink", 5},
            {"juice", 2},
            {"cocktail", 5},
            {"burger", 8},
            {"pasta", 11},
            {"ice Cream", 4}
        };
    }
    public int OrderTime(string order)
    {
        Console.WriteLine($"Waiter: Kitchen! We have an order for you");

        int time = timePrepare[order];
        Console.WriteLine($"Waiter: Ordered {order}. The time for cooking: {time} min. Will you wait?");

        return time;
    }

    public string Confirmation(bool confirm, string order)
    {
        if(confirm)
        {
            Console.WriteLine($"Customer: Yes I can wait");
            return PrepareOrder(order);
        }

        else
        {
            return "";
        }
    }

    private string PrepareOrder(string order)
    {
        _cooking = new TimeSpan(0, 0, timePrepare[order]);
        
        Console.WriteLine($"Waiter: {order} is ready!");
        
        return order;
    }
}