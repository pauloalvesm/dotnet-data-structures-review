internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Queue Data Structure - Using the Queue class **********");

        Queue<int> queue = new Queue<int>();

        Enqueue(queue, 10);
        Enqueue(queue, 20);
        Enqueue(queue, 30);

        CheckFront(queue);

        Console.WriteLine("Dequeuing two elements:");
        Dequeue(queue);
        Dequeue(queue);

        CheckFront(queue);

        Enqueue(queue, 40);
        CheckFront(queue);

        Console.WriteLine($"Queue is empty: {IsQueueEmpty(queue)}");

        Console.WriteLine("\n-------- Result --------");

        Console.WriteLine("Dequeuing all elements:");
        Dequeue(queue);

        Console.WriteLine($"Queue is empty after dequeuing all elements: {IsQueueEmpty(queue)}");

        Console.ReadKey();
    }

    private static void CheckFront(Queue<int> queue) 
    {
        if (!IsQueueEmpty(queue))
        {
            Console.WriteLine($"Element at the front: {queue.Peek()}");
        }
        else 
        {
            Console.WriteLine("The queue is empty.");
        }
    }

    private static void Enqueue(Queue<int> queue, int element) 
    {
        queue.Enqueue(element);
        Console.WriteLine($"Enqueuing: {element}");
    }

    private static void DequeueAll(Queue<int> queue) 
    {
        while (!IsQueueEmpty(queue)) 
        {
            Dequeue(queue);
        }
    }

    private static void Dequeue(Queue<int> queue) 
    {
        if (!IsQueueEmpty(queue))
        {
            Console.WriteLine($"Dequeuing: {queue.Dequeue()}");
        }
        else 
        {
            Console.WriteLine("The queue is already empty.");
        }
    }

    private static bool IsQueueEmpty(Queue<int> queue) 
    {
        return queue.Count == 0;
    }
}