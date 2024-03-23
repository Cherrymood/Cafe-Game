public interface IHandleOrder
{
    int HandleOrder(List<Dish> menu, Queue<Dish> orderQueue, IKitchen kitchen, IOrderBill cashier, Queue<ICustomer> customerQueue, Random rn);
}