namespace DataStructures.Stack01.Models;

public class StackModel<T>
{
    private T[] elements;
    private int top;

    public StackModel(int size)
    {
        elements = new T[size];
        top = -1;
    }

    public void Push(T element) 
    {
        if (top == elements.Length - 1) 
        {
            throw new InvalidOperationException("The stack is full.");
        }

        elements[++top] = element;
    }

    public T Pop() 
    {
        if (top == -1) 
        {
            throw new InvalidOperationException("The stack is empty.");
        }

        return elements[top--];   
    }

    public T Peek() 
    {
        if (top == -1) 
        {
            throw new InvalidOperationException("The stack is empty.");
        }

        return elements[top];
    }

    public bool IsEmpty() 
    {
        return top == -1;
    }

    public int Size() 
    {
        return top + 1;
    }
}
