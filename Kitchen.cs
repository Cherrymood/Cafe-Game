class Kitchen{
   
    private Dictionary<string, int> timePrepare;
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
        Console.WriteLine("Kitchen! We have an order for you");
    }
    public int OrderTime(string order)
    {
        int time = timePrepare[order];
        Console.WriteLine($"Ordered {order}. The time for cooking: {time} min. Will you wait?");

        return time;
    }
}