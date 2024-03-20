public interface ICustomer
{
    Dish MakeOrders(Random rn, List<Dish> menu);
    int WaitingTime(Random rn);
    int PayBill(int bill);
}