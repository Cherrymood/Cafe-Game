public interface IHandleCustomer
{
   Queue<Dish> HandleCustomer(Queue<ICustomer> customerQueue, Random rn, List<Dish> menu, ICustomer customer, ITakeOrder waiter, ICustomer vipCustomer, PrintOutMenue _printer, int _amountOrders);

}