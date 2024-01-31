using System;
class Program
{
    static Func<int, int, int> PerformOperation(Func<int, int, int> operation)
    {
        return operation;
    }
    static void Main(string[] args)
    {
        Func<int, int, int> add = (a, b) => a + b;
        Func<int, int, int> multiply = (a, b) => a * b;
        Func<int, int, int> operation = PerformOperation(add);
        Console.WriteLine("Addition: " + operation(5, 3)); // Output: 8
        operation = PerformOperation(multiply);
        Console.WriteLine("Multiplication: " + operation(5, 3)); // Output: 15
    }
}
