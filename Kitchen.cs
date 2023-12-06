public class Kitchen
{
    private Dictionary<string, int> menuPrice;
    private Dictionary<string, int> menuTime;

    public Kitchen()
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

    public void OrderDish(string dishName)
    {
        if (menuPrice.ContainsKey(dishName) && menuTime.ContainsKey(dishName))
        {
            int price = menuPrice[dishName];
            int time = menuTime[dishName];

            // Perform actions related to the order (e.g., print receipt, start preparation, etc.)
            Console.WriteLine($"Ordered {dishName}. Price: {price}, Preparation Time: {time} minutes");
        }
        else
        {
            Console.WriteLine($"{dishName} is not on the menu.");
        }
    }
}