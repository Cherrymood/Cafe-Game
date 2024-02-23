using System;
using System.Collections.Generic;

public class PrintOutMenue : IPrint
{
    private List<Dish> _menu;

    public PrintOutMenue(string connectionString)
    {
        DataAccess dataAccess = new DataAccess(connectionString);
        _menu = dataAccess.GetMenu();
    }

    public void Print()
    {
        foreach(var dish in _menu)
        {
            Console.WriteLine("Name: {0}, Price: {1}, Description: {2}", dish.DishName, dish.Price, dish.DishDescription);
        }
    }
}
