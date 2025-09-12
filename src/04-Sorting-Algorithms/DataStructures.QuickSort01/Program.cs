using DataStructures.Helpers.Utilities;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Quick Sort Algorithm **********");

        Console.Write("Enter the size of the array: ");
        int arraySize = int.Parse(Console.ReadLine());

        int[] array = new int[arraySize];
        HelperCollections.ReadArray(array, arraySize);

        Console.WriteLine("\n-------- Original array --------");
        HelperCollections.PrintFullArray(array);

        SortArray(array, 0, arraySize - 1);

        Console.WriteLine("\n-------- Sorted array --------");
        HelperCollections.PrintFullArray(array);

        Console.ReadKey();
    }

    private static void SortArray(int[] array, int low, int high) 
    {
        if (low < high) 
        {
            int index = PartitionLastElement(array, low, high);
            SortArray(array, low, index - 1);
            SortArray(array, index + 1, high);
        }
    }

    private static int PartitionLastElement(int[] array, int low, int high) 
    {
        int pivot = array[high];
        int i = low - 1;

        for (int j = low; j < high; j++) 
        {
            if (array[j] <= pivot) 
            {
                i++;
                SwapElement(array, i, j);
            }
        }

        SwapElement(array, i + 1, high);

        return i + 1;
    }

    private static void SwapElement(int[] array, int i, int j) 
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}