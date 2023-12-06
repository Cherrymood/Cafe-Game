
using System.Reflection.Metadata.Ecma335;

class Customer{

    private Kitchen _menu;

    public Customer()
    {
        Console.WriteLine("Here is our menu.");
        
        _menu = new Kitchen();
    }

    public string MakeOrder()
    {
        Console.Write("Enter your order (or 'q' to quit): ");

        string order = Console.ReadLine();

        _menu.OrderDish(order);

        return order;

    }
}
        

