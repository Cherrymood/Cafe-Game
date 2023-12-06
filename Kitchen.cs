class Kitchen{
   
    private Dictionary<string, int> timing;
    public Kitchen()
    {
        this.timing = new Dictionary<string, int>
        {
            {"soup", 5},
            {"meat", 10},
            {"snacks", 2},
            {"salad", 5},
            {"pizza", 10},
            {"water", 1},
            {"hot drink", 3},
            {"juice", 2},
            {"cocktail", 5},
            {"burger", 5},
            {"pasta", 8},
        };
    }

    public int PreperingTime(string order)
    {
        int time = timing[order];
        Console.WriteLine($"Ordered {order}. The time for cooking: {time} min.");
        
        return time;
    }
}