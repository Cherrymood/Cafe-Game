class Customer
{
    private int _tips;
    private string _key;
    private Menue _menue;

    public Customer()
    {
        Console.WriteLine("Here is our menue.");
        this._menue = menue;
        menue = new Menue();
        this._key = key;
        key = "";
        _tips =  1;
    } 
    
    public string MakeOrder()
    {
        Random rand = new Random();
        List<string> keys = Enumerable.ToList(menue.menuePrice.keys);
        int size = menue.menuePrice.Count;
        key = keys[rand.Next(size)];
        Console.WriteLine("Thank you, for your order. The waiting time is {0}, and the cost will be {1}", menue.menueTime(key), menue.menuePrice(key));
    
        return key;
    }

    public int Payment()
    {
        Random r = new Random(); // could i initialize it only in constructor and use it in all methods?
        int wait = r.Next(0, 12);

        if (wait == menue.menueTime(_key))
        {
            Console.WriteLine("Thank you. Here you are my money for my order.");

            return menue.menuePrice(key) + _tips;
        }
        else
        {

            Console.WriteLine("Thank you, I am in hurry. I can not wait anymore");

            return 0;
        }

    }

}