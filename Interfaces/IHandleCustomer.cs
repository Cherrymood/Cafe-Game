public interface IHandleCustomer
{
    Queue<ICustomer> CustomerQueue (ICustomer customer, ICustomer vipCustomer, Random _rn, int _amountOrders);
}