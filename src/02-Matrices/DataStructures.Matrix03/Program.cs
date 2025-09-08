using DataStructures.Helpers.Utilities;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Transposing a 3x4 Matrix to 4x3 **********");

        int rows = 3;
        int columns = 4;

        int[,] matrix3x4 = HelperCollections.ReadMatrix(rows, columns);
        int[,] matrix4x3 = TransposeMatrix(matrix3x4);

        Console.WriteLine("\n-------- Result --------");
        Console.WriteLine("Transposed 4x3 matrix:");
        HelperCollections.PrintMatrix(matrix4x3);

        Console.ReadKey();
    }

    private static int[,] TransposeMatrix(int[,] matrix) 
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        int[,] transposedMatrix = new int[columns, rows];

        for (int i = 0; i < rows; i++) 
        {
            for (int j = 0; j < columns; j++) 
            {
                transposedMatrix[j, i] = matrix[i, j];
            }
        }

        return transposedMatrix;
    }
}