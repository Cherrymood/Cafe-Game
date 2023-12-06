public class Customer
{
    private Kitchen _menu;

    public Customer()
    {
        Console.WriteLine("Here is our menu.");
        _menu = new Kitchen();
    }

    public void MakeOrders()
    {
        while (true)
        {
            Console.Write("Enter your order (or 'q' to quit): ");
            string order = Console.ReadLine();

            if (order.ToLower() == "q")
            {
                Console.WriteLine("That's all. Thank you!");
                break;
            }

            _menu.OrderDish(order);
        }
    }
}