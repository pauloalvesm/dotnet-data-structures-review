using DataStructures.Helpers.Utilities;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Display Array Operations **********");

        int[] X = new int[10];
        int[] Y = new int[10];

        Console.WriteLine("Enter 10 values for array X:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"X[{i}] = ");
            X[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter 10 values for array Y:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Y[{i}] = ");
            Y[i] = int.Parse(Console.ReadLine());
        }

        int[] union = CheckUnion(X, Y);
        int[] difference = CheckDifference(X, Y);
        int[] intersection = CheckIntersection(X, Y);

        Console.WriteLine("\n---------- Result ----------");

        Console.WriteLine("\nUnion of X and Y:");
        HelperCollections.PrintArray(union);

        Console.WriteLine("\nDifference of X and Y:");
        HelperCollections.PrintArray(difference);

        Console.WriteLine("\nIntersection of X and Y:");
        HelperCollections.PrintArray(intersection);

        Console.ReadKey();
    }

    private static int[] CheckUnion(int[] array1, int[] array2)
    {
        int[] result = new int[20];

        for (int i = 0; i < 10; i++)
        {
            result[i] = array1[i];
        }

        for (int i = 0; i < 10; i++)
        {
            bool foundValue = false;

            for (int j = 0; j < 10; j++)
            {
                if (array2[i] == result[j])
                {
                    foundValue |= true;
                    break;
                }
            }

            if (!foundValue)
            {
                result[10 + i] = array2[i];
            }
        }

        return result;
    }

    private static int[] CheckDifference(int[] array1, int[] array2)
    {
        int[] result = new int[10];

        for (int i = 0; i < 10; i++)
        {
            bool foundValue = false;

            for (int j = 0; j < 10; j++)
            {
                if (array1[i] == array2[j])
                {
                    foundValue = true;
                    break;
                }
            }

            if (!foundValue)
            {
                result[i] = array1[i];
            }
        }

        return result;
    }

    private static int[] CheckIntersection(int[] array1, int[] array2)
    {
        int[] result = new int[10];

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (array1[i] == array2[j])
                {
                    result[i] = array1[i];
                    break;
                }
            }
        }

        return result;
    }
}