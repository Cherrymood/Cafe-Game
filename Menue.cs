private class Menue
{
    { 
        // name of dish and time to return to customer
        private Dictionary MenueKitchen = new Dictionary <string, int> {
            {"Soup", 10},
            {"Meat", 15},
            {"Snaks", 2},
            {"Salad", 5},
            {"Pizza", 12}
        };
        private Dictionary MenueBar = new Dictionary <string, int> {
            {"Water", 1},
            {"Hot drink", 5},
            {"Juice", 2},
            {"Cocktail", 5},
        };

        MenueKitchen.Add("Cheese plate", 3);
        MenueBar.Add("Sparkling", 1);
    }
}