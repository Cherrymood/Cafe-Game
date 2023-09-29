public class Cafe
{
    private Customer _customer;
    private Kitchen _kitchen;
    private Workers _workers;
    private string _order;

    public Cafe(string order)
    {
        this._order = order;
    }
}