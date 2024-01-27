class PrintOutMenue : IPrint
{
    private Menue _menue;

    public PrintOutMenue()
    {
        _menue = new Menue();
    }

    public void Print()
    {
        var menue = _menue.GetMenue();

        foreach(var kvp in menue)
        {
            Console.WriteLine("{0} price is {1}", kvp.Key, kvp.Value);
        }
    }

}