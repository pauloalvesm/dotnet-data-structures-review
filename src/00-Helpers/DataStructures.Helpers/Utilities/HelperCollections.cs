namespace DataStructures.Helpers.Utilities;

public class HelperCollections
{
    public static void ReadArray(int[] array, int arraySize)
    {
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write($"Element [{i}] = ");
            array[i] = int.Parse(Console.ReadLine());
        }
    }

    public static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != 0)
            {
                Console.Write($"{array[i]} ");
            }
        }

        Console.WriteLine();
    }

    public static void PrintFullArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }

        Console.WriteLine();
    }

    public static int[,] ReadMatrix(int rows, int columns)
    {
        int[,] matrix = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Enter value for position ({i + 1}, {j + 1}): ");

                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    matrix[i, j] = value;
                }
                else
                {
                    Console.WriteLine("Invalid value. Please try again.");
                    j--;
                }
            }
        }

        return matrix;
    }

    public static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{matrix[i, j]} \t");
            }

            Console.WriteLine();
        }
    }

    public static void PrintMatrix(int[,] matrix, int rows, int columns)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{matrix[i, j]} \t");
            }

            Console.WriteLine();
        }
    }

}
