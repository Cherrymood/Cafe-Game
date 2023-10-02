private class Customers
{
    private int _tips;
    private bool _refuseWait;
    private Menue _menue;

    public Customer()
    {
        Console.WriteLine("Welcome to our customer! Here is our menue.");
        var menue = new Menue();
        this._menue = menue;
        
    } 
    
    private string MakeOrder(Menue menue)
    {
        Random rand = new Random();
        List<TValue> keys = Enumerable.ToList(menue.Menue.Keys);
        int size = menue.Menue.Count;
    
        return keys[rand.Next(size)];
}

    private int WaitTime()
    {
        Random rnd = new Random();
        var WaitTime = rnd.Next(0, 12);




    }




}