public class Customer
{
    public Customer()
    {
        Console.WriteLine("Here is our menu.");
    }
    public string MakeOrders()
    {
            Console.Write("Enter your order (or 'q' to quit): ");
            string order = Console.ReadLine();

            if (order.ToLower() == "q")
            {
                Console.WriteLine("That's all. Thank you!");
            }

        return order;
    }
}