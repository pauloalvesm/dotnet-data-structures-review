using DataStructures.Helpers.Utilities;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Console.Write("Enter the size of the array: ");
        int arraySize = int.Parse(Console.ReadLine());

        int[] array = new int[arraySize];
        HelperCollections.ReadArray(array, arraySize);

        Console.WriteLine("\n-------- Original array --------");
        HelperCollections.PrintFullArray(array);

        ExecuteMergeSort(array);

        Console.WriteLine("\n-------- Sorted array --------");
        HelperCollections.PrintFullArray(array);

        Console.ReadKey();
    }

    private static void ExecuteMergeSort(int[] array)
    {
        int left = 0;
        int right = array.Length - 1;
        SortArray(array, left, right);
    }

    private static void SortArray(int[] array, int left, int right) 
    {
        if (left < right)
        {
            int middle = (left + right) / 2;
            SortArray(array, left, middle);
            SortArray(array, middle + 1, right);
            MergeArrays(array, left, middle, right);
        }
    }

    private static void MergeArrays(int[] array, int left, int middle, int right) 
    {
        int number1 = middle - left + 1;
        int number2 = right - middle;

        int[] leftArray = new int[number1];
        int[] rightArray = new int[number2];

        for (int i = 0; i < number1; i++) 
        {
            leftArray[i] = array[left + i];
        }

        for (int j = 0; j < number2; j++) 
        {
            rightArray[j] = array[middle + 1 + j];
        }

        int x = 0, y = 0;
        int k = left;

        while (x < number1 && y < number2)
        {
            if (leftArray[x] <= rightArray[y])
            {
                array[k] = leftArray[x];
                x++;
            }
            else
            {
                array[k] = rightArray[y];
                y++;
            }

            k++;
        }

        while (x < number1)
        {
            array[k] = leftArray[x];
            x++;
            k++;
        }

        while (y < number2)
        {
            array[k] = rightArray[y];
            y++;
            k++;
        }
    }
}