public interface IHandleCustomer
{
   Queue<Dish> HandleCustomer(Queue<ICustomer> customerQueue, Random rn, List<Dish> menu, ITakeOrder waiter, PrintOutMenue _printer);

}