private class Customers
{
    private int _tips;
    private bool _refuseWait;
    private Menue _menue;
    private Kitchen _prepareTime;

    public Customer(Menue menue)
    {
        Console.WriteLine("Welcome to our customer");
        this._menue = menue;
    } 
    
    private Menue MakeOrderKitchen(Menue menue)
    {
        Random choice = new Random();
        var randomValue2 = menue.MenueKitchen[choice.Next];

        return randomValue1 + randomValue2;
    }

    private int WaitTime()
    {
        Random rnd = new Random();
        var WaitTime = rnd.Next(0, 12);




    }




}