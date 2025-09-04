using DataStructures.Helpers.Utilities;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Array - Search Number in Array **********");

        Console.Write("\nEnter the size of the array: ");
        int arraySize = int.Parse(Console.ReadLine());

        int[] array = new int[arraySize];

        Console.WriteLine();

        HelperCollections.ReadArray(array, arraySize);

        Console.Write("\nEnter a number to search in the array: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("\n---------- Result ----------");

        Console.WriteLine();

        bool searchResult = SearchNumberInArray(array, number);

        if (searchResult)
        {
            Console.WriteLine($"The number {number} was found in the array!");
        }
        else 
        {
            Console.WriteLine($"The number {number} does not exist in the array!");
        }

            Console.ReadKey();
    }

    private static bool SearchNumberInArray(int[] array, int number) 
    {
        for (int i = 0; i < array.Length; i++) 
        {
            if (array[i] == number) 
            {
                return true;
            }
        }

        return false;
    }
}