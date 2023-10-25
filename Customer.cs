class Customer
{
    private int tips;
    private string key;
    private Menu menu; // Corrected the class name to "Menu"
    private Random random;

    public Customer()
    {
        Console.WriteLine("Here is our menu.");
        menu = new Menu();
        key = "";
        tips = 1;
        random = new Random();
    }

    public string MakeOrder()
    {
        List<string> keys = Enumerable.ToList(menu.menuPrice.Keys);
        int size = keys.Count;
        key = keys[random.Next(size)];
        Console.WriteLine("Thank you for your order. The waiting time is {0}, and the cost will be {1}", menu.menuTime.GetValueOrDefault(key), menu.menuPrice.GetValueOrDefault(key));
        return key;
    }

    public int Payment()
    {
        int wait = random.Next(0, 12);

        if (menu.menuTime.TryGetValue(key, out int time))
        {
            if (wait >= time)
            {
                Console.WriteLine("Thank you. Here is my money for my order.");
                return menu.menuPrice[key] + tips;
            }
            else
            {
                Console.WriteLine("Thank you, but I am in a hurry. I cannot wait any longer.");
                return 0;
            }
        }
        else
        {
            Console.WriteLine("The selected item is not on the menu.");
            return 0;
        }
    }
}
