class Cafe{
   
    private Dictionary<string, int> menuPrice;
    public Cafe()
    {
        this.menuPrice = new Dictionary<string, int>
        {
            {"Soup", 10},
            {"Meat", 15},
            {"Snacks", 2},
            {"Salad", 5},
            {"Pizza", 12},
            {"Water", 1},
            {"Hot drink", 5},
            {"Juice", 2},
            {"Cocktail", 5},
            {"Burger", 8},
            {"Pasta", 11},
            {"Ice Cream", 4},
            {"Sushi", 20},
            {"Steak", 18},
            {"Sandwich", 6},
            {"Fries", 3},
            {"Pancakes", 7},
            {"Coffee", 3},
            {"Tea", 2},
            {"Milkshake", 4},
            {"Fish", 14}
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