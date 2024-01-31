using System;
class Program
{
    static void Main(string[] args)
    {
        Func<int, int> addTwo = x => x + 1;
        Func<int, int> multiplyByThree = y => y * 2;
        Func<int, int> composedFunction = x => multiplyByThree(addTwo(x));
        Console.WriteLine("Result: " + composedFunction(3));
    }
}
