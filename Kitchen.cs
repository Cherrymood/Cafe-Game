public class Kitchen : IKitchen
{
    public int CookingTime(Dish order)
    {
        Console.WriteLine("Kitchen: We got an new order");

        Thread.Sleep(1000); // Simulate cooking time

        return order.PrepareTime;
    }
}