class Cafe
{
    private Kitchen _kitchen;
    private Menue _menue;
    public Cafe()
    {
        _kitchen = new Kitchen();
        _menue = new Menue();
    }

    public Dictionary<string,int> GiveMenue()
    {
        Console.WriteLine($"Waiter: Hello, How are you? Here is our menue");
        return _menue.GetMenue();
    }
    public int GetConfirmation(int customerWaitTime, int kitchenCookingTime, string order)
    {
        Console.WriteLine($"Waiter: The time for cooking: {kitchenCookingTime} min.");
        if(customerWaitTime >= kitchenCookingTime)
        {
            string cookedMeal = _kitchen.Confirmation(order);
            int bill = OrderDishPrice(cookedMeal);
            return bill;
        }
        else
        {
            Console.WriteLine($"Waiter: Sorry, we cannot prepare your order in time. Bye!");
            return 0;
        }
    }
    
    private int OrderDishPrice(string order)
    {
        int price = menue[order];

        if (price > 0)
        {
            Console.WriteLine($"Waiter: Ordered {order}. The price: {price} doll.");
        }
        else
        {
            Console.WriteLine($"Waiter: {order} is not in our menu.");
        }
      
        return price;
    }
}