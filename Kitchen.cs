public class Kitchen : IKitchen
{
    public Kitchen()
    {
        Console.WriteLine("Kitchen: We are ready!");
    }

    public int CookingTime(Dish order)
    {
        Console.WriteLine("Kitchen: We got an new order");
        return order.PrepareTime;
    }
}