using System.Runtime.CompilerServices;

public interface ITakeOrder
{
    void TakeOrder(Dish order, Queue<Dish> _orderQueue);
}