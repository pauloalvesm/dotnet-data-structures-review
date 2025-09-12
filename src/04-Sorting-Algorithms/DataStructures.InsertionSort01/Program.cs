using DataStructures.Helpers.Utilities;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Insertion Sort Algorithm **********");

        Console.Write("Enter the array size: ");
        int arraySize = int.Parse(Console.ReadLine());

        int[] array = new int[arraySize];
        HelperCollections.ReadArray(array, arraySize);

        Console.WriteLine("\n-------- Original array --------");
        HelperCollections.PrintArray(array);

        ExecuteInsertionSort(array);

        Console.WriteLine("\n-------- Sorted array --------");
        HelperCollections.PrintArray(array);

        Console.ReadKey();
    }

    private static void ExecuteInsertionSort(int[] array) 
    {
        int number = array.Length;

        for (int i = 1; i < number; i++) 
        {
            int key = array[i];
            int j;

            for (j = i - 1; j >= 0 && array[j] > key; j--) 
            {
                array[j + 1] = array[j];
            }

            array[j + 1] = key;
        }
    }
}