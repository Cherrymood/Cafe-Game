public class Kitchen
{
    private Dictionary<string, int> _timePrepare;
    private TimeSpan _cooking;

    public Kitchen()
    {
        _timePrepare = new Dictionary<string, int>
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

    public int OrderTime(string order)
    {
        if(_timePrepare.ContainsKey(order))
        {
            return _timePrepare[order];
        }
        return 0;
    }

    public int GetOrderTime(string order)
    {
        if (_timePrepare.ContainsKey(order))
        {
            return _timePrepare[order];
        }
        else
        {
            throw new ArgumentException($"Kitchen: Error - No preparation time found for {order}.");
        }
    }

    public string Confirmation(string order)
    {
        try
        {
            int preparationTime = GetOrderTime(order);
            return PrepareOrder(order);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
            return "";
        }
    }

    private string PrepareOrder(string order)
    {
        _cooking = new TimeSpan(0, 0, _timePrepare[order]);
        Console.WriteLine($"Kitchen: {order} is ready!");
        return order;
    }
}
