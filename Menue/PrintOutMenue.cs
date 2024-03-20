using System;
using System.Collections.Generic;

public class PrintOutMenue : IPrint
{
    public void Print(List<Dish> menu)
    {
        foreach (Dish dish in menu)
        {
            Console.WriteLine($"Name: {dish.DishName}, Price: {dish.Price}, Description: {dish.DishDescription}");
        }
    }
}
