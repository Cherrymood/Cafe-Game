private class Customers
{
    private int _tips;
    private bool _refuseWait;
    private Menue _menue;
    private string _key;
    private Kitchen _preparingTime;

    public Customer()
    {
        Console.WriteLine("Welcome to our customer! Here is our menue.");
        var menue = new Menue();
        this._menue = menue;
        var preparingTime = new Kitchen();
        this._preparingTime = preparingTime;
        var tips =  menue.menue(key) * 0,05;
        var refuseWait = false;
        this._refuseWait = refuseWait;
    
    } 
    
    private string MakeOrder(Menue menue)
    {
        Random rand = new Random();
        List<TValue> keys = Enumerable.ToList(menue.menue.Keys);
        int size = menue.menue.Count;
        this._key = var key = keys[rand.Next(size)];
        Console.WriteLine("Thank you, for your order. The waiting time is {0}, and the cost will be {1}", preparingTime.menueTime(key), menue.menue(key));
    
        return key;
}

    private int Payment(string key)
    {
        Random r = new Random(); // could i initialize it only in constructor and use it in all methods?
        int wait = r.Next(0, 12);

        if (wait == preparingTime.menueTime(key))
        {
            Console.WriteLine("Thank you. Here you are my money for my order."

            return menue.menue(key) + tips;
        }
        else
        {
            refuseWait = true;

            Console.WriteLine("Thank you, I am in hurry. I can not wait anymore"

            return 0;
        }

    }




}