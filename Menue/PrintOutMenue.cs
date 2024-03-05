using System;
using System.Collections.Generic;

public class PrintOutMenue : IPrint
{
    private readonly DataAccess _db;

    public PrintOutMenue(string connectionString)
    {
        _db = new DataAccess(connectionString);
    }

    public void Print()
    {
        List<Dish> menu = _db.GetMenu();

        foreach (var dish in menu)
        {
            Console.WriteLine("Name: {0}, Price: {1}, Description: {2}", dish.DishName, dish.Price, dish.DishDescription);
        }
    }
}