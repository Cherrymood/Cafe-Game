public interface ICustomer
{
    string MakeOrders(Dictionary<string, int> menu);
    int WaitingTime();
    int PayBill(int bill);
}