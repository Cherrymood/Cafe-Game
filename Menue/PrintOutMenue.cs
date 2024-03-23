using System;
using System.Collections.Generic;

public class PrintOutMenue : IPrint
{
    public void Print(List<Dish> menu)
    {
        foreach (Dish dish in menu)
        {
            Console.WriteLine($"{dish.DishName}\tIt costs: {dish.Price}");
            
            Console.WriteLine($"------------------------------------------");
        }
    }
}
