using DataStructures.Helpers.Utilities;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Display Operations on a 5x3 Matrix **********");

        int rows = 5;
        int ccolumns = 3;
        int[,] matrix = new int[rows, ccolumns];

        for (int i = 0; i < rows; i++) 
        {
            Console.Write($"Enter the value for position [{i}, 0]: ");
            matrix[i, 0] = int.Parse( Console.ReadLine() );
        }

        Console.WriteLine("\n---------- Result ----------");
        AddingElementsValues(matrix);
        DuplicatingElementsValues(matrix);
        HelperCollections.PrintMatrix(matrix, rows, ccolumns);

        Console.ReadKey();
    }

    private static void AddingElementsValues(int[,] matrix) 
    {
        const int valueToAdd = 10;

        for (int i = 0; i < matrix.GetLength(0); i++) 
        {
            matrix[i, 1] = matrix[i, 0] + valueToAdd;
        }
    }

    private static void DuplicatingElementsValues(int[,] matrix) 
    {
        const int multiplier = 2;

        for (int i = 0; i < matrix.GetLength(0); i++) 
        {
            matrix[i, 2] = matrix[i, 0] * multiplier;
        }
    }
}