using System;

public class Waiter : IOrderHandler
{
    private Customer _customer;

    public Waiter(Customer customer)
    {
        _customer = customer;
    }

    public int TakeOrder()
    {
        Console.WriteLine("Waiter: Hello, How are you? Here is our menu");

        // Call MakeOrders method of the customer to get the order
        Dish orderedDish = _customer.MakeOrders();

        Console.WriteLine($"Waiter: Ordered {orderedDish.DishName}. The price: {orderedDish.Price} dollars.");
        return orderedDish.Price;
    }
}
