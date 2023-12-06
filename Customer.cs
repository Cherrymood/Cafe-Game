public class Customer
{
    private Random random;
    public Customer()
    {
        random = new Random();
        Console.WriteLine("Hello could I have a menue?");
    }
    public string MakeOrders()
    {
            Console.Write("Enter your order (or 'q' to quit): ");
            string order = Console.ReadLine();
            order.ToLower();

        return order;
    }
    public int WaitTime()
    {
        int waitTime = random.Next(0, 15);
        Console.Write("I cannot wait more, than {0} min", waitTime);

        return waitTime;
    }
}