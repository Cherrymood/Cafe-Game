public class Kitchen : IKitchen
{
    public Kitchen()
    {
        Console.WriteLine("Kitchen: We got an new order");
    }

    public int CookingTime(Dish order)
    {
        return order.PrepareTime;
    }
}