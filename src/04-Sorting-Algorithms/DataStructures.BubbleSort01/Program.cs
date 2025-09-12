using DataStructures.Helpers.Utilities;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Bubble Sort Algorithm **********");

        Console.Write("Enter the array size: ");
        int arraySize = int.Parse(Console.ReadLine());

        int[] array = new int[arraySize];
        HelperCollections.ReadArray(array, arraySize);

        ExecuteBubbleSort(array);

        Console.WriteLine("\n-------- Result --------");
        HelperCollections.PrintArray(array);

        Console.ReadKey();
    }

    private static void ExecuteBubbleSort(int[] array) 
    {
        int number = array.Length;
        bool swapped;

        for (int i = 0; i < number - 1; i++) 
        {
            swapped = false;

            for (int j = 0; j < number - i - 1; j++) 
            {
                if (array[j] > array[j + 1]) 
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                    swapped = true;
                }
            }

            if (!swapped) 
            {
                break;
            }
        }
    }
}