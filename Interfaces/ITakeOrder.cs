using System.Runtime.CompilerServices;

public interface ITakeOrder
{
    void TakeOrder(Dish orderedDish, Queue<Dish> _orderQueue, PrintOutMenue _printer, List<Dish> _menu);
}