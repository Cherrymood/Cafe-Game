class Customer
{
    public int tips;
    public string key;
    public Menue menue;

    public Customer()
    {
        Console.WriteLine("Here is our menue.");
        
        menue = new Menue();
        key = "";
        tips =  1;
    } 
    
    public string MakeOrder(Menue menue)
    {
        Random rand = new Random();
        List<string> keys = Enumerable.ToList(menue.menuePrice.Keys);
        int size = keys.Count;
        key = keys[rand.Next(size)];
        Console.WriteLine("Thank you, for your order. The waiting time is {0}, and the cost will be {1}", menue.menueTime(key), menue.menuePrice(key));
    
        return key;
    }

    public int Payment(string key)
    {
        Random r = new Random(); // could i initialize it only in constructor and use it in all methods?
        int wait = r.Next(0, 12);

        if (wait == menue.menueTime(key))
        {
            Console.WriteLine("Thank you. Here you are my money for my order.");

            return menue.menuePrice(key) + tips;
        }
        else
        {

            Console.WriteLine("Thank you, I am in hurry. I can not wait anymore");

            return 0;
        }

    }

}