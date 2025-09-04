using DataStructures.Helpers.Utilities;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Array - Display Even and Odd Numbers **********");

        int arraySize = 10;
        int[] array = new int[arraySize];
        int evenNumbers = 0;
        int oddNumbers = 0;

        Console.WriteLine();

        HelperCollections.ReadArray(array, arraySize);
        CountEvenAndOdd(array, ref evenNumbers, ref oddNumbers);

        Console.WriteLine("\n-------- Array Elements --------");
        HelperCollections.PrintArray(array);

        Console.WriteLine("\n-------- Result --------");
        Console.WriteLine($"Quantity of even numbers: {evenNumbers}");
        Console.WriteLine($"Quantity of odd numbers: {oddNumbers}");

        Console.ReadKey();
    }

    private static void CountEvenAndOdd(int[] array, ref int even, ref int odd) 
    {
        for (int i = 0; i < array.Length; i++) 
        {
            if (array[i] % 2 == 0)
            {
                even++;
            }
            else 
            {
                odd++;
            }
        }
    }
}