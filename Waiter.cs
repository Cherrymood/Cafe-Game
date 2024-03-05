using System;

public class Waiter : ITakeOrder
{
    private Queue<Dish> _orderQueue;
    public Waiter(Queue<Dish> orderQueue)
    {
        Console.WriteLine("Waiter: Hello, How are you? Here is our menu");
        _orderQueue = orderQueue;
    }

    public void TakeOrder(Dish orderedDish, Queue<Dish> _orderQueue)
    {
        _orderQueue.Enqueue(orderedDish);

        Console.WriteLine($"Waiter: Ordered {orderedDish.DishName}. The price: {orderedDish.Price} dollars.");
    }
}