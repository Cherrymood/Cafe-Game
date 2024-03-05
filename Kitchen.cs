public class Kitchen : IKitchen
{
    private Customer _customer;

    public Kitchen(Customer customer)
    {
        _customer = customer;
    }

    public int CookingTime(string order)
    {
        return  _customer.MakeOrders().PrepareTime;
    }
}