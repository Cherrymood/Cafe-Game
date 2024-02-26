public interface ICafe
{
    int GetBill(int customerWaitTime, string order);
    string HandleCustomer(int orderIndex, ref int target);
}