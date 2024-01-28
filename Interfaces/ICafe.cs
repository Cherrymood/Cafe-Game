public interface ICafe
{
    int GetBill(int customerWaitTime, int kitchenCookingTime, string order);
    string HandleCustomer(int orderIndex, ref int target);
}