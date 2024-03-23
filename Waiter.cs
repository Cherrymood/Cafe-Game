using System;

public class Waiter : ITakeOrder
{
    public void TakeOrder(Dish orderedDish, Queue<Dish> _orderQueue, PrintOutMenue _printer, List<Dish> _menu)
    {
       Console.WriteLine("Waiter: Hello, How are you? Here is our menu");

        _printer.Print(_menu);

       _orderQueue.Enqueue(orderedDish);

        Console.WriteLine($"Waiter: Ordered {orderedDish.DishName}. Great choise! {orderedDish.DishDescription}");
    }
}