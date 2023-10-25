class Menu
{
    public Dictionary<string, int> menuPrice;
    public Dictionary<string, int> menuTime;

    public Menu()
    {
        this.menuPrice = new Dictionary<string, int> {
            {"Soup", 10},
            {"Meat", 15},
            {"Snacks", 2},
            {"Salad", 5},
            {"Pizza", 12},
            {"Water", 1},
            {"Hot drink", 5},
            {"Juice", 2},
            {"Cocktail", 5},
            {"Nothing", 0}
        };
        this.menuTime = new Dictionary<string, int> {
            {"Soup", 5},
            {"Meat", 6},
            {"Snacks", 2},
            {"Salad", 5},
            {"Pizza", 12},
            {"Water", 2},
            {"Hot drink", 6},
            {"Juice", 6},
            {"Cocktail", 7},
            {"Nothing", 0}
        };
    }
}
