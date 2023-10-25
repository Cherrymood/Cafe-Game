
    class Customer{

    private int tips;
    private List<string> keys;
    private Menu menu;
    private Random random;
    private int totalCost;

    public Customer()
    {
        Console.WriteLine("Here is our menu.");
        menu = new Menu();
        keys = new List<string>();
        tips = 1;
        random = new Random();
    }

    public int MakeOrder()
    {
        while (true)
        {
            Console.WriteLine("Menu:");
            foreach (var item in menu.menuPrice)
            {
                Console.WriteLine($"{item.Key}: ${item.Value}");
            }

            Console.Write("Enter your order (or 'q' to quit): ");
            string order = Console.ReadLine();

            if (order.ToLower() == "q")
            {
                Console.WriteLine($"Your total cost is: ${totalCost}");
                break;
            }

            if (menu.menuPrice.ContainsKey(order))
            {
                totalCost += menu.menuPrice[order];
                keys.Add(order);
                Console.WriteLine($"Added {order} to your order. Total cost: ${totalCost}");
            }
            else
            {
                Console.WriteLine("Invalid item. Please choose from the menu.");
            }
        }

        return totalCost; // Return the total cost of the order
    }

    public int Payment(int orderCost)
    {
        int waitTotal = 0;
        int timeTotal = 0;

        foreach (var k in keys)
        {
            if (menu.menuTime.TryGetValue(k, out int time))
            {
                int wait = random.Next(0, 15);
                waitTotal += wait;
                timeTotal += time;
            }
            else
            {
                Console.WriteLine("The selected item is not on the menu.");
            }
        }

        if (waitTotal >= timeTotal)
        {
            Console.WriteLine("Thank you. Here is my money for my order.");
            return (int)(orderCost + tips);
        }
        else
        {
            Console.WriteLine("Thank you, but I am in a hurry. I cannot wait any longer.");
            return 0;
        }
    }
}

