class Menue{

    public Dictionary<string, int> menue;

    public Menue()
    {
        menue = new Dictionary<string, int>
        {
            {"soup", 10},
            {"meat", 15},
            {"snacks", 2},
            {"salad", 5},
            {"pizza", 12},
            {"water", 1},
            {"coffee", 5},
            {"juice", 2},
            {"cocao", 5},
            {"burger", 8},
            {"pasta", 11},
            {"cake", 4}
        };
    }

    public void PrintOutMenue()
    {
        foreach (KeyValuePair<string, int> position in menue)
        {
            Console.WriteLine("{0}:\t\t{1}$", position.Key, position.Value);
        }
    }
    public int ReturnPrice(string order)
    {
        if(menue.ContainsKey(order))
        {
            return menue[order];
        }
        else
        {
            return 0;
        }
    }
}