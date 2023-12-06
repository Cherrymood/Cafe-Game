class Kitchen{
   
    private Dictionary<string, int> timePrepare;
    public Kitchen()
    {
        this.timePrepare = new Dictionary<string, int>
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
        if (timePrepare.ContainsKey(order))
        {
            int time = timePrepare[order];

            // Perform actions related to the order (e.g., print receipt, start preparation, etc.)
            Console.WriteLine($"Ordered {order}. The time for cooking: {time} min.");
            return time;
        }
        else
        {
            Console.WriteLine($"{order} is not on the menu.");
            return 0;
        }
    }
}