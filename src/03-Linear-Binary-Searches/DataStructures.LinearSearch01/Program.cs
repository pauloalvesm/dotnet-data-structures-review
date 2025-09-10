using DataStructures.Helpers.Utilities;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Largest Element in the Array **********");

        Console.Write("Enter the size of the array: ");
        int arraySize = int.Parse(Console.ReadLine());

        int[] array = new int[arraySize];
        HelperCollections.ReadArray(array, arraySize);

        int largestElementInArray = FindLargestElement(array);

        Console.WriteLine("\n-------- Result --------");
        Console.WriteLine($"The largest element in the array is: {largestElementInArray}");

        Console.ReadKey();
    }

    private static int FindLargestElement(int[] array) 
    {
        int largestElement = array[0];

        for (int i = 1; i < array.Length; i++) 
        {
            if (array[i] > largestElement) 
            {
                largestElement = array[i];
            }
        }

        return largestElement;
    }
}