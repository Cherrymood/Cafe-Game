using System;

public class Waiter : ITakeOrder
{
    private Queue<Dish> _orderQueue;
    public Waiter()
    {
        Console.WriteLine("Waiter: Hello, How are you? Here is our menu");
        _orderQueue = new Queue<Dish>();
    }

    public void TakeOrder(Dish orderedDish, Queue<Dish> _orderQueue)
    {
        _orderQueue.Enqueue(orderedDish);

        Console.WriteLine($"Waiter: Ordered {orderedDish.DishName}. The price: {orderedDish.Price} dollars.");
    }
}