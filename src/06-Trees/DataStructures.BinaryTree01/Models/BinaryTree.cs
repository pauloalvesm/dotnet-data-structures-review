namespace DataStructures.BinaryTree01.Models;

public class BinaryTree
{
    private int[] tree;
    private int size;

    public BinaryTree(int capacity)
    {
        tree = new int[capacity];
        size = 0;
    }

    public void Insert(int inputValue) 
    {
        if (size == tree.Length) 
        {
            Console.WriteLine("The tree is full");
            return;
        }

        tree[size] = inputValue;
        size++;
    }

    public void PrintInOrder(int index)
    {
        if (!IsIndexValid(index))
        {
            return;
        }

        PrintInOrder(2 * index + 1);

        Console.Write($"{tree[index]}  ");

        PrintInOrder(2 * index + 2);
    }

    public void PrintPreOrder(int index) 
    {
        if (!IsIndexValid(index))
        {
            return;
        }

        Console.Write($"{tree[index]}  ");

        PrintPreOrder(2 * index + 1);

        PrintPreOrder(2 * index + 2);
    }

    public void PrintPostOrder(int index) 
    {
        if (!IsIndexValid(index)) 
        {
            return;
        }

        PrintPostOrder(2 * index + 1);

        PrintPostOrder(2 * index + 2);

        Console.Write($"{tree[index]}  ");
    }

    private bool IsIndexValid(int index) 
    {
        return index < size;
    }
}
