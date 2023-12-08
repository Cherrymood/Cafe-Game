class Cafe{
   
    private Dictionary<string, int> _menuPrice;
    private Kitchen _kitchen;
    public Cafe()
    {
        _kitchen = new Kitchen();
        _menuPrice = new Dictionary<string, int>
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
    public Dictionary<string, int> GiveMenue()
    {
        Console.WriteLine($"Waiter: Here is our menu.");

        foreach (var key in _menuPrice.Keys)
        {
            Console.WriteLine(key);
        }

        return _menuPrice;
    }
    
    public int GetConfirmation(int customerWaitTime, int kitchenCookingTime, string order)
    {
        Console.WriteLine($"Waiter: Ordered {order}. The time for cooking: {kitchenCookingTime} min.");
        if(customerWaitTime >= kitchenCookingTime)
        {
            string cookedMeal = _kitchen.Confirmation(true, order);
            int bill = OrderDishPrice(cookedMeal);
            return bill;
        }
        else
        {
            Console.WriteLine($"Waiter: Sorry, we cannot prepare your order in time. Bye!");
            return 0;
        }
    }
    
    private int OrderDishPrice(string order)
    {
        if (_menuPrice.ContainsKey(order))
        {
            int price = _menuPrice[order];
            Console.WriteLine($"Waiter: Ordered {order}. The price: {price} doll.");
            return price;
        }
        else
        {
            Console.WriteLine($"Waiter: {order} is not on the menu.");
            return 0;
        }
    }
}