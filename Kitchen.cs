private class Kitchen
{
    { 
        // name of dish and time
        public Dictionary MenueKitchenTime = new Dictionary <string, int> {
            {"Soup", 5},
            {"Meat", 6},
            {"Snaks", 2},
            {"Salad", 5},
            {"Pizza", 12}
        };
        public Dictionary MenueBarTime = new Dictionary <string, int> {
            {"Water", 2},
            {"Hot drink", 6},
            {"Juice", 6},
            {"Cocktail", 7},
        };

        MenueKitchen.Add("Cheese plate", 3);
        MenueBar.Add("Sparkling", 1);
        MenueKitchen.Add("Nothing", 0);
        MenueBar.Add("Nothing", 0);
    }
}