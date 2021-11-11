using System;

namespace ADOPM2_05_05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rectangular arrays represent an n-dimensional block of memory

            // 2-dimensional rectangular array
            int[,] matrix = new int[3, 3];      // unitialized
            int[,] matrix2 =  {{0,1,2},         // initialized
                               {3,4,5},
                               {6,7,8}};

            Console.WriteLine(matrix2[1, 2]);  // 5

            //Print out a matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write($"{matrix2[row,column]},  ");
                }
                Console.WriteLine();
            }


            // Initialize the array individually
            // The GetLength method of an array returns the length for a given dimension (starting at 0):
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = row * 25 + col * 43;
                }
            }

            // Write the matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col],-4}");
                }
                Console.WriteLine();
            }

            // Write the matrix2
            Console.WriteLine();
            for (int row = 0; row < matrix2.GetLength(0); row++)
            {
                for (int col = 0; col < matrix2.GetLength(1); col++)
                {
                    Console.Write($"{matrix2[row, col],-4}");
                }
                Console.WriteLine();
            }
        }
    }
}
// Exercise:
// 1.   Make multidimensionals array 3x3 in size of the types bool, double, long, string. Initialize them with some values.
//      Iterate over rows and columns and printout the values using nested for-loops
// 2.   Make an multidimensional array of struct Point, 2x2 in size. Initialize it with 4 different Point cooridinates.
//      - Iterate over the array using two nested foreach-loops and find the longest Vector. Print out the longest Vector.
//      - Iterate over the array using two nested for-loops and find the longest Vector. Print out the longest Vector.
//      - Iterate over the array using two nested while-loops and find the longest Vector. Print out the longest Vector.
//      Which of the nested loop structures were most convenient to work with?