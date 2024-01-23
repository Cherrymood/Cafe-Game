public interface ICustomer
{
    string MakeOrders(int orderIndex);
    int WaitingTime();
    int PayBill(int bill);
}