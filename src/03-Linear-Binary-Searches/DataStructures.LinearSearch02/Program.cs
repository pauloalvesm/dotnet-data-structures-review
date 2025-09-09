using DataStructures.Helpers.Utilities;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Occurrence Counter **********");

        Console.Write("Enter the array size: ");
        int arraySize = int.Parse(Console.ReadLine());

        int[] array = new int[arraySize];
        HelperCollections.ReadArray(array, arraySize);

        Console.Write("Enter the element you want to count: ");
        int element = int.Parse(Console.ReadLine());

        int occurrences = CountOccurrences(array, element);

        Console.WriteLine("\n-------- Result --------");
        Console.WriteLine($"The element {element} appears {occurrences} times in the array.");

        Console.ReadKey();
    }

    private static int CountOccurrences(int[] array, int element) 
    {
        int counter = 0;

        for (int i = 0; i < array.Length; i++) 
        {
            if (array[i] == element) 
            {
                counter++;
            }
        }

        return counter;
    }
}