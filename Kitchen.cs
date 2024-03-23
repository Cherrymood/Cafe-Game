public class Kitchen : IKitchen
{
    public int CookingTime(Dish order)
    {
        Console.WriteLine("Kitchen: We got an new order");

       while(order.PrepareTime > 0)
       {
            order.PrepareTime--;
       } // Simulate cooking time

        Console.WriteLine($"Kitchen: {order.DishName} is ready!");

        return order.PrepareTime;
    }
}