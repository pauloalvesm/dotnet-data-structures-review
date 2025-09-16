namespace DataStructures.Queue01.Models;

public class QueueModel<T>
{
    private T[] elements;
    private int head;
    private int tail;
    private int count;

    public QueueModel(int capacity)
    {
        elements = new T[capacity];
        head = 0;
        tail = -1;
        count = 0;
    }

    public void Enqueue(T item)
    {
        if (count == elements.Length)
        {
            throw new InvalidOperationException("The queue is full.");
        }

        tail = (tail + 1) % elements.Length;
        elements[tail] = item;
        count++;
    }

    public T Dequeue()
    {
        if (count == 0)
        {
            throw new InvalidOperationException("The queue is empty.");
        }

        T item = elements[head];
        head = (head + 1) % elements.Length;
        count--;
        return item;
    }

    public T Peek()
    {
        if (count == 0)
        {
            throw new InvalidOperationException("The queue is empty.");
        }

        return elements[head];
    }

    public bool IsEmpty()
    {
        return count == 0;
    }

    public int Count()
    {
        return count;
    }
}
