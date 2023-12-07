class Cafe{
   
    private Dictionary<string, int> menuPrice;
    public Cafe()
    {
        menuPrice = new Dictionary<string, int>
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

        foreach (var key in menuPrice.Keys)
        {
            Console.WriteLine(key);
        }

        return menuPrice;
    }
    
    public int OrderDishPrice(string order)
    {
        if (menuPrice.ContainsKey(order))
        {
            int price = menuPrice[order];

            // Perform actions related to the order (e.g., print receipt, start preparation, etc.)
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