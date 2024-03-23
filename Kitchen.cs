public class Kitchen : IKitchen
{
    public int CookingTime(Dish order)
    {
        Console.WriteLine("Kitchen: We got an new order");

        var prepTime = order.PrepareTime;

       while(prepTime > 0)
       {
            prepTime--;
       } // Simulate cooking time

        Console.WriteLine($"Kitchen: {order.DishName} is ready!");

        return order.PrepareTime;
    }
}