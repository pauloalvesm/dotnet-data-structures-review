using DataStructures.Helpers.Utilities;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Shell Sort Algorithm **********");

        Console.Write("Enter the array size: ");
        int arraySize = int.Parse(Console.ReadLine());

        int[] array = new int[arraySize];
        HelperCollections.ReadArray(array, arraySize);

        Console.WriteLine("\n-------- Original array --------");
        HelperCollections.PrintFullArray(array);

        ExecuteShellSort(array);

        Console.WriteLine("\n-------- Sorted array --------");
        HelperCollections.PrintFullArray(array);

        Console.ReadKey();
    }

    private static void ExecuteShellSort(int[] array) 
    {
        int number = array.Length;

        for (int gap = number / 2; gap > 0; gap /= 2) 
        {
            for (int i = gap; i < number; i += 1) 
            {
                int temp = array[i];
                int j;

                for (j = i; j >= gap && array[j - gap] > temp; j -= gap) 
                {
                    array[j] = array[j - gap];
                }

                array[j] = temp;
            }
        }
    }
}