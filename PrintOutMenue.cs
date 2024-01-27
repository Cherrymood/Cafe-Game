class PrintOutMenue : IPrint
{
    private PrintOutMenue _printer;
    private Menue _menue;

    public PrintOutMenue()
    {
        _printer = new PrintOutMenue();
        _menue = new Menue();
    }

    public void Print()
    {
        var menue = _menue.GetMenue();

        foreach(var kvp in menue)
        {
            Console.WriteLine("{0} price is {1}", kvp.Keys, kvp.Values);
        }
    }

}