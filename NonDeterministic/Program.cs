using System;
class Program
{
    static int GenerateRandomNumber()
    {
        Random random = new Random();
        return random.Next(1, 100);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Random Number: " + GenerateRandomNumber());
    }
}
