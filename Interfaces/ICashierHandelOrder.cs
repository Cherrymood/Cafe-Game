public interface ICashierHandleOrder
{
   int CashierHandleOrder(Dish order, IOrderBill cashier, ICustomer customer);
}