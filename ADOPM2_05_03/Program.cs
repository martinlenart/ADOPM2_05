using System;

namespace ADOPM2_05_03
{
    class Program
    {
        public class Point
        {
            public int X, Y;
        }
        static void Main(string[] args)
        {
            int? x = 5;             // Value 5 as type instance of int
            int? y = null;          // Undefined value

            // Equality operator examples
            Console.WriteLine(x == y);      // False
            Console.WriteLine(x == null);   // False
            Console.WriteLine(x == 5);      // True
            Console.WriteLine(y == null);   // True
  
            // You can mix and match nullable and non-nullable types
            Console.WriteLine();
            int? a = null;
            int b = 2;
            int? c = a + b;                 // c is null - equivalent to a + (int?)b
            Console.WriteLine(c);           // null
            Console.WriteLine(c.HasValue);  // false

            a = 5;
            c = a + b;
            Console.WriteLine(c);           // 7
 
            // ?? and ??= operators
            string s1 = null;
            string s2 = s1 ?? "nothing";
            Console.WriteLine(s2); // nothing

            s1 ??= "something";
            Console.WriteLine(s1);  // something

            s1 ??= "everything";
            Console.WriteLine(s1);  // something
            
            // ?. operator
            Console.WriteLine();
            Point point1 = null;

            Point point2 = new Point { X = 50, Y = 100 };
            Console.WriteLine(point1?.X);            // null
            Console.WriteLine(point2?.X);            // 50

            var pointArray = new[] { new Point { X = 10, Y = 10 }, null};
            Console.WriteLine(pointArray[0]?.X);     // 10
            Console.WriteLine(pointArray[1]?.X);     // null

            // ?[] operator
            pointArray = null;
            Console.WriteLine(pointArray?[1]?.X);    // null
        }
    }
}
// Exercises
// 1.   Create variables of nullable value type bool?, float?, double?
//      - initialize to null
//      - ??= operators to assign the variable a value
//      - Create a second variable of same type and initialze using ?? based on the first variable
