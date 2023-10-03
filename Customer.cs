class Customer
{
    private int _tips;
    private string _key;
    private Menue _menue;
    private Menue _preparingTime;

    public Customer()
    {
        Console.WriteLine("Here is our menue.");
        _menue = new Menue();
        _preparingTime = new Menue();
        _tips =  1;
    } 
    
    public string MakeOrder()
    {
        Random rand = new Random();
        List<TValue> keys = Enumerable.ToList(_menue.menue.Keys);
        int size = _menue.menue.Count;
        _key = keys[rand.Next(size)];
        Console.WriteLine("Thank you, for your order. The waiting time is {0}, and the cost will be {1}", _preparingTime.menueTime(_key), _menue.menue(_key));
    
        return _key;
    }

    public int Payment()
    {
        Random r = new Random(); // could i initialize it only in constructor and use it in all methods?
        int wait = r.Next(0, 12);

        if (wait == _preparingTime.menueTime(_key))
        {
            Console.WriteLine("Thank you. Here you are my money for my order.");

            return _menue.menue(_key) + _tips;
        }
        else
        {

            Console.WriteLine("Thank you, I am in hurry. I can not wait anymore");

            return 0;
        }

    }

}