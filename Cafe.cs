class Cafe{

    private List<string> keys; // Assuming keys is a list in your context
    private Kitchen _menu; // Assuming _menu is an instance of the Kitchen class
    private Random random; // Assuming random is an instance of the Random class
    private int _tips = 1; // Assuming tips is an int variable


    public int Payment(int orderCost)
    {
        int waitTotal = 0;
        int timeTotal = 0;

        foreach (var k in keys)
        {
            if (_menu.menuTime.TryGetValue(k, out int time))
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