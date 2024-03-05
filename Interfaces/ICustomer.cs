public interface ICustomer
{
    Dish MakeOrders();
    int WaitingTime();
    int PayBill(int bill);
}