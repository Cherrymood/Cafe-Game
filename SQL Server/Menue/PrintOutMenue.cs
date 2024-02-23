using System;

public class PrintOutMenue : IPrint
{
    private Menue _menue;

    public PrintOutMenue(string connectionString)
    {
        _menue = new Menue(connectionString);
    }

    public void Print()
    {
        var menuItems = _menue.GetMenue();

        foreach(var dish in menuItems)
        {
            Console.WriteLine("Name: {0}, Price: {1}, Description: {2}", dish.DishName, dish.Price, dish.DishDescription);
        }
    }
}
