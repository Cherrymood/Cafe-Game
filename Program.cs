class Program
{
    static void Main(string[] args)
    {
        Cafe cafe = new Cafe();

        while (cafe.Level <= 2) // You can change the number of levels as needed
        {
            Console.WriteLine($"Level {cafe.Level}");
            cafe.StartGame();
            cafe.IncreaseLevel();
        }

        Console.WriteLine("Congratulations! You've completed all levels.");
    }
}
