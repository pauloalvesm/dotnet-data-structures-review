using DataStructures.Helpers.Utilities;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Populate a 5x5 Matrix **********");

        int rows = 5;
        int cols = 5;
        int[,] matrix = new int[rows, cols];

        int evenCount = 0;
        int oddCount = 0;
        int positiveCount = 0;
        int negativeCount = 0;
        int zeroCount = 0;

        for (int i = 0; i < rows; i++) 
        {
            for (int j = 0; j < cols; j++) 
            {
                Console.Write($"Enter the value for position [{i},{j}]: ");
                int number = int.Parse(Console.ReadLine());
                matrix[i, j] = number;

                if (IsEven(number))
                {
                    evenCount++;
                }
                else 
                {
                    oddCount++;
                }

                if (number > 0)
                {
                    positiveCount++;
                }
                else if (number < 0)
                {
                    negativeCount++;
                }
                else 
                {
                    zeroCount++;
                }
            }
        }

        Console.WriteLine("\n-------- 5x5 Matrix --------");

        HelperCollections.PrintMatrix(matrix);

        Console.WriteLine("\n-------- Result --------");
        Console.WriteLine($"Even numbers: {evenCount}");
        Console.WriteLine($"Odd numbers: {oddCount}");
        Console.WriteLine($"Positive numbers: {positiveCount}");
        Console.WriteLine($"Negative numbers: {negativeCount}");
        Console.WriteLine($"Zeros: {zeroCount}");

        Console.ReadKey();
    }

    private static bool IsEven(int number) 
    {
        return number % 2 == 0;
    }
}