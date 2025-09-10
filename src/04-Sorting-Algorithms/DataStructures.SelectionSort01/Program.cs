using DataStructures.Helpers.Utilities;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Selection Sort Algorithm **********");

        Console.Write("Enter the array size: ");
        int arraySize = int.Parse(Console.ReadLine());

        int[] array = new int[arraySize];
        HelperCollections.ReadArray(array, arraySize);

        ExecuteSelectionSort(array);

        Console.WriteLine("\n-------- Result --------");
        HelperCollections.PrintFullArray(array);

        Console.ReadKey();
    }

    private static void ExecuteSelectionSort(int[] array) 
    {
        int number = array.Length;

        for (int i = 0; i < number - 1; i++) 
        {
            int minIndex = i;

            for (int j = i + 1; j < number; j++) 
            {
                if (array[j] < array[minIndex]) 
                {
                    minIndex = j;
                }
            }

            int temp = array[i];
            array[i] = array[minIndex];
            array[minIndex] = temp;
        }
    }
}