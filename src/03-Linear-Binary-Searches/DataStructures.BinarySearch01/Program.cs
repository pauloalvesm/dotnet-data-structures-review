using DataStructures.Helpers.Utilities;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Check Array Sorting **********");

        Console.Write("Enter the array size: ");
        int arraySize = int.Parse(Console.ReadLine());

        int[] array = new int[arraySize];
        HelperCollections.ReadArray(array, arraySize);

        bool isSorted = CheckArraySorting(array);

        Console.WriteLine("\n-------- Result --------");

        if (isSorted)
        {
            Console.WriteLine("The array is sorted in ascending order.");
        }
        else 
        {
            Console.WriteLine("The array is NOT sorted in ascending order.");
        }
        
        Console.ReadKey();
    }

    private static bool CheckArraySorting(int[] array) 
    {
        for (int i = 1; i < array.Length; i++) 
        {
            if (array[i] < array[i - 1]) 
            {
                return false;
            }
        }

        return true;
    }
}