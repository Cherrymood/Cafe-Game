class Customer
{
    private int tips;
    private List<string> keys;
    private Menu menu; // Corrected the class name to "Menu"
    private Random random;
    private double totalCost; // Added totalCost to keep track of the total order cost

    public Customer()
    {
        Console.WriteLine("Here is our menu.");
        menu = new Menu();
        tips = 1;
        random = new Random();
    }

    public void MakeOrder()
    {
        keys = new List<string>();

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
                break;

            if (menu.menuPrice.ContainsKey(order))
            {
                totalCost += menu.menuPrice[order];
                keys.Add(order); // Add the ordered item to the list
                Console.WriteLine($"Added {order} to your order. Total cost: ${totalCost}");
            }
            else
            {
                Console.WriteLine("Invalid item. Please choose from the menu.");
            }
        }

        Console.WriteLine($"Your total cost is: ${totalCost}");
        Console.WriteLine("Thank you for your order!");
    }


    public int Payment()
    {
        int waitTotal = 0;
        int timeTotal = 0;
        int totalPayment = 0;


        foreach (var k in keys)
        {
            if (menu.menuTime.TryGetValue(k, out int time))
            {
                int wait = random.Next(0, 15);
                waitTotal += wait;
                timeTotal += time;
                totalPayment += menu.menuPrice[k] + tips;
            }
            else
            {
                Console.WriteLine("The selected item is not on the menu.");
            }
        }
        if (waitTotal >= timeTotal)
                {
                    Console.WriteLine("Thank you. Here is my money for my order.");
                    
                }
                else
                {
                    Console.WriteLine("Thank you, but I am in a hurry. I cannot wait any longer.");
                    return 0;
                }

        key.Clear();
        
        return totalPayment; // Return the total payment after the loop
        
        }
}  