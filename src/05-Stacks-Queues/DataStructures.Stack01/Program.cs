using DataStructures.Stack01.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Data Structure Stack **********");

        StackModel<int> stack = new StackModel<int>(5);

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        Console.WriteLine($"Element at the top: {stack.Peek()}");

        Console.WriteLine($"Popping: {stack.Pop()}");
        Console.WriteLine($"Popping: {stack.Pop()}");

        Console.WriteLine($"Element at the top: {stack.Peek()}");

        stack.Push(40);
        Console.WriteLine($"Element at the top: {stack.Peek()}");

        while (!stack.IsEmpty())
        {
            Console.WriteLine($"Popping: {stack.Pop()}");
        }

        Console.WriteLine("\n-------- Result --------");

        Console.WriteLine($"Is stack empty: {stack.IsEmpty()}");

        Console.ReadKey();
    }
}