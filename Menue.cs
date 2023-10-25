class Menu
{
    public Dictionary<string, int> menuPrice;
    public Dictionary<string, int> menuTime;

    public Menu()
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
        this.menuTime = new Dictionary<string, int>
        {
            {"Soup", 5},
            {"Meat", 6},
            {"Snacks", 2},
            {"Salad", 5},
            {"Pizza", 12},
            {"Water", 2},
            {"Hot drink", 6},
            {"Juice", 6},
            {"Cocktail", 7},
            {"Burger", 8},
            {"Pasta", 10},
            {"Ice Cream", 4},
            {"Sushi", 15},
            {"Steak", 12},
            {"Sandwich", 5},
            {"Fries", 3},
            {"Pancakes", 7},
            {"Coffee", 3},
            {"Tea", 2},
            {"Milkshake", 4},
            {"Fish", 14}
        };
    }
}
