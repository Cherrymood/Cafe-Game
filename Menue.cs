private class Menue
{
    { 
        // name of dish and cost
        public Dictionary Menue = new Dictionary <string, int> {
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
    }
}