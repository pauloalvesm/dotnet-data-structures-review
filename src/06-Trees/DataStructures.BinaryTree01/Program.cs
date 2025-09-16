using DataStructures.BinaryTree01.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Data Structure Binary Tree **********");

        BinaryTree binaryTree = new BinaryTree(10);

        binaryTree.Insert(1);
        binaryTree.Insert(2);
        binaryTree.Insert(3);
        binaryTree.Insert(4);
        binaryTree.Insert(5);
        binaryTree.Insert(6);
        binaryTree.Insert(7);

        Console.WriteLine("\nIn-Order Traversal: ");
        binaryTree.PrintInOrder(0);
        Console.WriteLine();

        Console.WriteLine("\nPre-Order Traversal: ");
        binaryTree.PrintPreOrder(0);
        Console.WriteLine();

        Console.WriteLine("\nPost-Order Traversal: ");
        binaryTree.PrintPostOrder(0);
        Console.WriteLine();

        Console.ReadKey();
    }
}