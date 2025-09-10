using DataStructures.Helpers.Utilities;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Search for Element with Binary Search **********");

        Console.Write("Enter the array size: ");
        int arraySize = int.Parse(Console.ReadLine());

        int[] array = new int[arraySize];
        HelperCollections.ReadArray(array, arraySize);

        Console.Write("\nEnter the value to be searched: ");
        int inputValue = int.Parse(Console.ReadLine());

        int searchResult = BinarySearch(array, inputValue);

        Console.WriteLine("\n-------- Result --------");

        if (searchResult != 1)
        {
            Console.WriteLine($"The value {inputValue} was found at index {searchResult}.");
        }
        else 
        {
            Console.WriteLine($"The value {inputValue} was not found in the array.");
        }

        Console.ReadKey();
    }

    private static int BinarySearch(int[] array, int inputValue) 
    {
        int start = 0;
        int end = array.Length -1;

        while (start <= end) 
        {
            int middle = start + (end - start) / 2;

            if (array[middle] == inputValue)
            {
                return middle;
            }
            else if (array[middle] < inputValue)
            {
                start = middle + 1;
            }
            else 
            {
                end = middle - 1;
            }
        }

        return -1;
    }
}