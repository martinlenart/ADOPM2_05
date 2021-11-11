using System;

namespace ADOPM2_05_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x = 5;
            int? y = null;

            // Equality operator examples
            Console.WriteLine(x == y);    // False
            Console.WriteLine(x == null); // False
            Console.WriteLine(x == 5);    // True
            Console.WriteLine(y == null); // True
            Console.WriteLine(y == 5);    // False
            Console.WriteLine(y != 5);    // True

            // You can mix and match nullable and non-nullable types
            int? a = null;
            int b = 2;
            int? c = a + b;   // c is null - equivalent to a + (int?)b
            Console.WriteLine(c); // null

            // ?. operator
            string s1 = null;
            Console.WriteLine(s1?.Length);

            System.Text.StringBuilder sb = null;
            int? length = sb?.ToString().Length;
            Console.WriteLine(length);   // null


            // The ?? operator 
            int? x1 = null;
            int y1 = x1 ?? 5;
            Console.WriteLine(y1);   // 5

            int? a1 = null, b1 = 1, c1 = 2;
            Console.WriteLine(a1 ?? b1 ?? c1);  // 1 

            //Boxing an unboxing
            object o = null;
            int? x3 = o as int?;
            Console.WriteLine(x3.HasValue);   // False
        }
        //Exercises:
        //1.    Try out expressions using various nullable value types, bool?, long?, double? etc. Mix in expressions with 
        //      non nullable types. Explain what happens.
    }
}
