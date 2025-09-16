internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Stack Data Structure - Using the Stack class **********");

        Stack<int> stack = new Stack<int>();

        Push(stack, 10);
        Push(stack, 20);
        Push(stack, 30);

        CheckTop(stack);

        Console.WriteLine("Popping two elements:");
        Pop(stack);
        Pop(stack);

        CheckTop(stack);

        Push(stack, 40);
        CheckTop(stack);

        Console.WriteLine($"Is stack empty: {IsStackEmpty(stack)}");

        Console.WriteLine("\n-------- Result --------");

        Console.WriteLine("Popping all elements:");
        PopAll(stack);

        Console.WriteLine($"Is stack empty after popping all elements: {IsStackEmpty(stack)}");

        Console.ReadKey();
    }

    private static void CheckTop(Stack<int> stack) 
    {
        if (!IsStackEmpty(stack))
        {
            Console.WriteLine($"Element at the top: {stack.Peek()}");
        }
        else
        {
            Console.WriteLine("The stack is empty.");
        }
    }

    private static void Push(Stack<int> stack, int item) 
    {
        stack.Push(item);
        Console.WriteLine($"Pushing: {item}");
    }

    private static void Pop(Stack<int> stack) 
    {
        if (!IsStackEmpty(stack))
        {
            Console.WriteLine($"Popping: {stack.Pop()}");
        }
        else
        {
            Console.WriteLine("The stack is already empty.");
        }
    }

    private static void PopAll(Stack<int> stack) 
    {
        while (!IsStackEmpty(stack))
        {
            Pop(stack);
        }
    }

    private static bool IsStackEmpty(Stack<int> stack) 
    {
        return stack.Count == 0;
    }
}