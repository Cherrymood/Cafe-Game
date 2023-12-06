using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public class Kitchen
{
    private Dictionary<string, int> menuTime;

    public Kitchen()
    {
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
    public int OrderDishTime(string dishName)
    {
        if (menuTime.ContainsKey(dishName))
        {
            int time = menuTime[dishName];

            // Perform actions related to the order (e.g., print receipt, start preparation, etc.)
            Console.WriteLine($"Ordered {dishName}. Preparation Time: {time} minutes");
            return time;
        }
        else
        {
            Console.WriteLine($"{dishName} is not on the menu.");
            return 0;
        }
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}