class Cafe{
   
    private Dictionary<string, int> menuPrice;
    public Cafe()
    {
        this.menuPrice = new Dictionary<string, int>
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
        };
    }

    public int OrderDishPrice(string dishName)
    {
        if (menuPrice.ContainsKey(dishName))
        {
            int price = menuPrice[dishName];

            // Perform actions related to the order (e.g., print receipt, start preparation, etc.)
            Console.WriteLine($"Ordered {dishName}. The price: {price} doll.");
            return price;
        }
        else
        {
            Console.WriteLine($"{dishName} is not on the menu.");
            return 0;
        }
    }
}