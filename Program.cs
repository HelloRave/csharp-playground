using csharp_playground;
using System.Diagnostics.Metrics;

namespace DataTypesVariables

{

    public class Program

    {

        public static void Main(string[] args)

        {
            // Declare a single-dimensional array of 5 integers.
            int[] array1 = new int[5];
            array1[0] = 20;
            array1[1] = 30;
            array1[2] = 50;
            array1[3] = 50;
            array1[4] = 50;
            Console.WriteLine(array1.Length);

            int[] array4 = new int[5];
            for (int i = 0;  i < array4.Length; i++)
            {
                array4[i] = i;
                Console.WriteLine(i);
            }

            int[] array5 = new int[5];
            foreach(int i in array5)
            {
                array5[i] = i;
                Console.WriteLine(i);
            }

            // Declare and set array element values.
            int[] array2 = { 1, 2, 3, 4, 5, 6 };
            int[] array3 = new int[] { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine(array2.Length);
            Console.WriteLine(array3.Length);

            // Declare a two dimensional array.
            int[,] multiDimensionalArray1 = new int[3, 3];
            Console.WriteLine("Dimension of array: {0}", multiDimensionalArray1.Rank);

            int counter = 0;
            for (int i = 0; i < multiDimensionalArray1.GetLength(0); i++)
            {
                for (int j = 0; j < multiDimensionalArray1.GetLength(1); j++)
                {
                    multiDimensionalArray1[i, j] = counter++;
                }
            }

            foreach (int item in multiDimensionalArray1)
            {
                if (item %  2 == 0)
                {
                    Console.WriteLine(item);
                }
            }

            for (int i = 0; i < multiDimensionalArray1.GetLength(0); i++)
            {
                for (int j = 0; j < multiDimensionalArray1.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine(multiDimensionalArray1[i, j]);
                    }
                }
            }

            for (int i = 0; i < multiDimensionalArray1.GetLength(0); i++)
            {
                Console.WriteLine(multiDimensionalArray1[i,i]);
            }

            // Declare and set array element values.
            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine("Accessing value in 2D array: {0}", multiDimensionalArray2[1,2]);
            foreach (int item in multiDimensionalArray2)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            // Declare a jagged array.
            int[][] jaggedArray = new int[6][];

            // Set the values of the first array in the jagged array structure.
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 };

        }


    }

}
