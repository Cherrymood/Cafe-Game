class Menue
{
    private Dictionary<string, int> menue;

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
    public Dictionary<string,int> GetMenue()
    {
        return menue;
    }
}