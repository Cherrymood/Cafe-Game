class Menu
{
    public Dictionary<string, int> MenuPrice { get; }
    public Dictionary<string, int> MenuTime { get; }

    public Menu()
    {
        {

            menuePrice = new Dictionary<string, int> {
            {"Soup", 10},
            {"Meat", 15},
            {"Snaks", 2},
            {"Salad", 5},
            {"Pizza", 12},
            {"Water", 1},
            {"Hot drink", 5},
            {"Juice", 2},
            {"Cocktail", 5},
            {"Nothing", 0}
            };

            menueTime = new Dictionary<string, int> {
            {"Soup", 5},
            {"Meat", 6},
            {"Snaks", 2},
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

         
}