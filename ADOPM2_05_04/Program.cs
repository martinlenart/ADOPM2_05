using System;

namespace ADOPM2_05_04
{
    class Program
    {
        #region Exercise
        struct Point
        {
            public int X, Y;
            public double Vector => Math.Sqrt(X * X + Y * Y);
        }
        #endregion

        static void Main(string[] args)
        {

            // Declare an array of 5 characters
            char[] vowels = new char[5];              // uninitialized
            int[] numbers = { 10, 25, 30, 35, 43 };   // initialzed

            // Square brackets also index the array, accessing a particular element by position:
            vowels[0] = 'a';
            vowels[1] = 'e';
            vowels[2] = 'i';
            vowels[3] = 'o';
            vowels[4] = 'u';
            
            Console.WriteLine(vowels[1]);      // e
            Console.WriteLine(numbers[1]);     // 25

            // for loop is excellent when you need to access by index []
            for (int i = 0; i < vowels.Length; i++)
                Console.Write($"{vowels[i]}{numbers[i]} ");            // a10 e25 i30 o35 u43

            // foreach is excelleny when you want to iterate of all elements
            // but you can only iterate over one enumerable
            Console.WriteLine();
            foreach (char c in vowels)
                Console.Write(c);            // aeiou

            Console.WriteLine();
            foreach (var i in numbers)
                Console.Write($"{i,-4}");            // 10   25   30   35  43

            // Array of string
            Console.WriteLine();
            Console.WriteLine();
            string[] words1 = { "The", "quick", "brown", "fox" }; // initialize by string literals

            foreach (var item in words1)
                Console.WriteLine(item);

            Console.WriteLine();
            string[] words2 = "The slow white dog".Split(' ');   // initialize with string.Split()
            foreach (var item in words2)
                Console.WriteLine(item);
        }
    }
}
// Exercise:
// 1.   Create an array of int that is 10 elements in size. Initialize it using a for-loop were each element has value index*2
// 2.   Create another array of int that is 10 elements in size. Initialize it using a foreach-loop were each element has value index*2
// 2a.  Iterate over the int array using a foreach-loop and find the largest, and smallest integer. Print them out.

// 3.   Make an array of struct Point, initialize it with 10 different Point cooridinates.
//      Iterate over it using a foreach-loop and find the longest Vector. Print out the longest Vector.  
// 4.   Modify the code in 1. to find also the shortest Vector. Printout both the longest and the shortest vectors.
// 5.   Initialize a string[] with the words in "A wonderful bird is the pelican" use string function Split().
//      Iterate over the string[] and print out each word.
// 6.   In the foreach-loop use continue to skip the printout of the word "wonderful".

