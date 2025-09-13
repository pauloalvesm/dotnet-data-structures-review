using DataStructures.Queue01.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Queue Data Structure **********");

        QueueModel<int> queue = new QueueModel<int>(5);

        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        Console.WriteLine($"Element at the front: {queue.Peek()}");

        Console.WriteLine($"Dequeueing: {queue.Dequeue()}");
        Console.WriteLine($"Dequeueing: {queue.Dequeue()}");

        Console.WriteLine($"Element at the front: {queue.Peek()}");

        queue.Enqueue(40);
        Console.WriteLine($"Element at the front: {queue.Peek()}");

        while (!queue.IsEmpty())
        {
            Console.WriteLine($"Dequeueing: {queue.Dequeue()}");
        }

        Console.WriteLine("\n-------- Result --------");

        Console.WriteLine($"Queue is empty: {queue.IsEmpty()}");

        Console.ReadKey();
    }
}