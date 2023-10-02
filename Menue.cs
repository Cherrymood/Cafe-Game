private class Menue
{
    { 
        // name of dish and cost
        public Dictionary menue = new Dictionary <string, int> {
            {"Soup", 10},
            {"Meat", 15},
            {"Snaks", 2},
            {"Salad", 5},
            {"Pizza", 12}
            {"Water", 1},
            {"Hot drink", 5},
            {"Juice", 2},
            {"Cocktail", 5},
        };

        Menue.Add("Cheese plate", 3);
        Menue.Add("Sparkling", 1);
        Menue.Add("Nothing", 0);

        // name of dish and time
        public Dictionary menueTime = new Dictionary <string, int> {
            {"Soup", 5},
            {"Meat", 6},
            {"Snaks", 2},
            {"Salad", 5},
            {"Pizza", 12}
            {"Water", 2},
            {"Hot drink", 6},
            {"Juice", 6},
            {"Cocktail", 7},
        };
        
        MenueTime.Add("Cheese plate", 3);
        MenueTime.Add("Sparkling", 1);
        MenueTime.Add("Nothing", 0);
    }
}