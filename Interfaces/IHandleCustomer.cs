public interface IHandleCustomer
{
    void HandleCustomer(Random rn, List<Dish> menu, ICustomer customer, ITakeOrder waiter, Queue<ICustomer> customerQueue, ICustomer vipCustomer, Queue<Dish> orderQueue);
    
}