using System;

namespace ADOPM2_05_06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Jagged arrays are arrays of arrays.
            // 2 dimensional jagged array
            int[][] matrix = new int[3][];                  // unitialized
            int[][] matrix2 = { new int[] {0,1,2,3},
                                new int[] {4,5,6,7,8,9},    // initialized
                                new int[] {10,11}};


            // Initialize the uninitialized array
            for (int i = 0; i < matrix.Length; i++)         // notice I use Length
            {
                int matrix_length = i switch
                {
                    0 => 4,
                    1 => 6,
                    2 => 2,
                    _ => 0
                };
                
                matrix[i] = new int[matrix_length];         // Create inner array
                for (int j = 0; j < matrix[i].Length; j++)  // notice I use matrix[i].Length
                    matrix[i][j] = i * 25 + j * 43;
            }
            
            // Write matrix
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                    Console.Write($"{matrix[i][j],-4}");

                Console.WriteLine();
            }

            // Write matrix2
            for (int i = 0; i < matrix2.Length; i++)
            {
                for (int j = 0; j < matrix2[i].Length; j++)
                    Console.Write($"{matrix2[i][j],-4}");

                Console.WriteLine();
            }
        }
    }
}
// Exercise:
// 1.   Make multidimensionals jagged array with 3 rows, each row with different number of columns (e.g., 2, 4, 1 columns) of the types bool, double, long, string.
//      Initialize the arrays with some values.
// 2.   Iterate over rows and columns and printout the values
//      - using nested foreach-loops
//      - using nested for-loops
//      Which of the nested loop structures were most convenient to work with?
