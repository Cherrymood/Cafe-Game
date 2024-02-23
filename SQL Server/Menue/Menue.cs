using System;
using System.Collections.Generic;

public class Menue
{
    private DataAccess _dataAccess;

    public Menue(string connectionString)
    {
        _dataAccess = new DataAccess(connectionString);
    }

    public List<Dish> GetMenue()
    {
        // Assuming DataAccess class has a method to retrieve menu items
        return _dataAccess.GetMenu();
    }
}
