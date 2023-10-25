class Program
{
    static void Main(string[] args)
    {
        Cafe cafe = new Cafe();

        while (cafe.Level <= 3) // You can change the number of levels as needed
        {
            Console.WriteLine($"Level {cafe.Level}");
            cafe.StartGame();
        }

        Console.WriteLine("Congratulations! You've completed all levels.");
    }
}
