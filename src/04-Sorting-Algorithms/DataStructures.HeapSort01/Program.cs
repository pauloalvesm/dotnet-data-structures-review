using DataStructures.Helpers.Utilities;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Heap Sort Algorithm **********");

        Console.Write("Enter the array size: ");
        int arraySize = int.Parse(Console.ReadLine());

        int[] array = new int[arraySize];
        HelperCollections.ReadArray(array, arraySize);

        SortArray(array);

        Console.WriteLine("\n-------- Sorted array --------");
        HelperCollections.PrintArray(array);

        Console.ReadKey();
    }

    private static void SortArray(int[] array) 
    {
        int number = array.Length;

        for (int i = number / 2 - 1; i >= 0; i--)
        {
            ExecuteHeapSort(array, number, i);
        }

        for (int i = number - 1; i > 0; i--)
        {
            int temp = array[0];
            array[0] = array[i];
            array[i] = temp;

            ExecuteHeapSort(array, i, 0);
        }
    }

    private static void ExecuteHeapSort(int[] array, int number, int index) 
    {
        int largest = index;
        int left = 2 * index + 1;
        int right = 2 * index + 2;

        if (left < number && array[left] > array[largest]) 
        {
            largest = left;
        }

        if (right < number && array[right] > array[largest]) 
        {
            largest = right;
        }

        if (largest != index) 
        {
            int swap = array[index];
            array[index] = array[largest];
            array[largest] = swap;

            ExecuteHeapSort(array, number, largest);
        }
    }
}