
class Customer{

    private int _tips;
    private List<string> _keys;
    private Kitchen _menu;
    private Random _random;
    private int _totalCost;

    public Customer()
    {
        Console.WriteLine("Here is our menu.");
        _menu = new Kitchen();
        _keys = new List<string>();
        _tips = 1;
        _random = new Random();
        _totalCost = 0;
    }

    public int MakeOrder()
    {
        _totalCost = 0; // Reset totalCost for each customer
        
        while (true)
        {
            Console.WriteLine("Menu:");
            foreach (var item in _menu.menuPrice)
            {
                Console.WriteLine($"{item.Key}: ${item.Value}");
            }

            Console.Write("Enter your order (or 'q' to quit): ");
            string order = Console.ReadLine();

            if (order.ToLower() == "q")
            {
                Console.WriteLine($"Your total cost is: ${_totalCost}");
                break;
            }

            if (_menu.menuPrice.ContainsKey(order, StringComparer.OrdinalIgnoreCase))
            {
                _totalCost += _menu.menuPrice[order];
                _keys.Add(order);
                Console.WriteLine($"Added {order} to your order. Total cost: ${_totalCost}");
            }
            else
            {
                Console.WriteLine("Invalid item. Please choose from the menu.");
            }
        }

        return _totalCost; // Return the total cost of the order
    }
}

