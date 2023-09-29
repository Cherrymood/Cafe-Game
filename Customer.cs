private class Customers
{
    private string _mood;
    private int _tips;
    private int _waitTime = 20;
    private bool _refuseWait;
    private Dictionary _menue;

    public Customer(Dictionary menue)
    {
        Console.WriteLine("Welcome to our customer");
        this._menue = menue;
    } 
    
    private string MakeOrder(Menue menue)
    {
        Random choice = new Random();
        var randomValue = menue.MenueBar[choice.Next(0, menue.Count)];

    }


}