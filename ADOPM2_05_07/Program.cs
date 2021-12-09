using System;

namespace ADOPM2_05_07
{
    #region Exercise
    public enum PlayingCardColor
    {
        Clubs, Diamonds, Hearts, Spades         // Poker suit order, Spades highest
    }
    public enum PlayingCardValue
    {
        Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
        Knight, Queen, King, Ace                // Poker Value order
    }
    public struct PlayingCardStruct
    {
        public PlayingCardColor Color;
        public PlayingCardValue Value;
    }
    public class PlayingCardClass
    {
        public PlayingCardColor Color;
        public PlayingCardValue Value;
    }
    #endregion
    class Program
    {
        public struct StructPoint
        {
            public long X, Y;
        }
        public class ClassPoint
        {
            public long X, Y;

            public ClassPoint() { }
            public ClassPoint(ClassPoint org)
            {
                X = org.X;
                Y = org.Y;
            }
            public override string ToString()
            {
                return $"(X:{X} Y:{Y})";
            }
        }

        static void Main(string[] args)
        {
            #region Shallow and Deep copy comparison
            Console.WriteLine("Shallow and Deep copy comparison");
            StructPoint sp1 = new StructPoint { X = 3, Y = 10 };
            StructPoint sp2 = new StructPoint { X = 30, Y = 100 };

            sp2 = sp1;
            Console.WriteLine($"X: {sp2.X} Y: {sp2.Y}"); // 3, 10

            sp1.X = 7;
            sp1.Y = 17;
            Console.WriteLine($"X: {sp1.X} Y: {sp1.Y}"); // 7, 17
            Console.WriteLine($"X: {sp2.X} Y: {sp2.Y}"); // 3, 10

            Console.WriteLine();
            ClassPoint cp1 = new ClassPoint { X = 3, Y = 10 };
            ClassPoint cp2 = new ClassPoint { X = 30, Y = 100 };

            //cp2 = cp1;    //Shallow copy
            //cp2 = new ClassPoint { X = cp1.X, Y = cp1.Y };  // Deep copy
            cp2 = new ClassPoint(cp1);  //Deep copy using copy constructor
            
            Console.WriteLine($"X: {cp2.X} Y: {cp2.Y}"); // 3, 10
            
            cp1.X = 7;
            cp1.Y = 17;
            Console.WriteLine($"X: {cp1.X} Y: {cp1.Y}"); // 7, 17
            Console.WriteLine($"X: {cp2.X} Y: {cp2.Y}"); // 3, 10
            #endregion

            #region Examples Clone and Copy gives shallow copy
            Console.WriteLine("\n\nClone and Copy makes shallow copy");
            // Arrays of Value Type
            StructPoint[] structArr = { new StructPoint { X = 1, Y = 1 }, new StructPoint { X = 2, Y = 2 } };
            int[] intArr = { 1, 2, 3, 4 };

            // Array of Reference Type
            ClassPoint[] classArr = { new ClassPoint { X = 3, Y = 3 }, new ClassPoint { X = 4, Y = 4 } };

            // Array of string (immutable reference type)
            string[] strArr = "the quick brown fox".Split();

            //Now lets copy the arrays, modify an original element and compare and compare
            // Clone Value types
            StructPoint[] structCopy = (StructPoint[])structArr.Clone();
            structArr[0].X = structArr[0].Y = 5;
            Console.WriteLine($"structCopy[0]: X = {structCopy[0].X}, Y = {structCopy[0].Y}"); // 1,1 
            Console.WriteLine($"structArr[0]: X = {structArr[0].X}, Y = {structArr[0].Y}");    // 5,5 

            int[] intCopy = (int[])intArr.Clone();
            intArr[0] = 5;
            Console.WriteLine($"\nintCopy[0] = {intCopy[0]}"); // 1 
            Console.WriteLine($"intArr[0] = {intArr[0]}");   // 5

            // Clone Reference types
            ClassPoint[] classCopy = (ClassPoint[])classArr.Clone();
            classArr[0].X = classArr[0].Y = 5;
            Console.WriteLine($"\nclassCopy[0]: X = {classCopy[0].X}, Y = {classCopy[0].Y}"); // 5,5 !! 
            Console.WriteLine($"classArr[0]: X = {classArr[0].X}, Y = {classArr[0].Y}");      // 5,5 

            //Clone String Type 
            string[] strCopy = (string[])strArr.Clone();
            strArr[1] = "slow";
            Console.WriteLine($"\nstrCopy[1] = {strCopy[1]}"); // quick !! 
            Console.WriteLine($"strArr[1] = {strArr[1]}");     // slow
            #endregion

            # region Demonstrate Deep copy using an array
            Console.WriteLine("\nDemonstrate Deep copy using an array");
            var rnd = new Random();
            ClassPoint[] myArray = new ClassPoint[5];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = new ClassPoint { X = rnd.Next(1, 100), Y = rnd.Next(1, 100) };
            }

            Console.WriteLine("myArray");
            foreach (var item in myArray)
            {
                Console.Write($"{item} ");
            }

            //Shallow copy creates problems
            ClassPoint[] myArrayCopy = (ClassPoint[])myArray.Clone();

            //Deep copy using copy constructor
            /*
            ClassPoint[] myArrayCopy = new ClassPoint[myArray.Length];
            for (int k = 0; k < myArray.Length; k++)
            {
                myArrayCopy[k] = new ClassPoint(myArray[k]);
            }
            */

            Console.WriteLine("\nyArrayCopy");
            foreach (var item in myArrayCopy)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            myArrayCopy[2].X = 1000;
            myArrayCopy[2].Y = 1000;

            Console.WriteLine("\nmyArray");
            foreach (var item in myArray)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\nArrayCopy");
            foreach (var item in myArrayCopy)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            #endregion
        }
    }
}
//Exercises:
//1.    Declare a variable as an array of type int with 5 elements. Initialize the array with values.
//      Declare another variable as an array of type int with and make it a shallow copy of the first array 
//
//2.	Declare a variable, cardDeckStruct1, as an array of type PlayingCardStruct with 5 elements.
//      Initialize it to 5 different playing cards. Declare another variable, cardDeckStruct2
//3.	Are cardDeckStruct1 of type value type or reference type?
//4.	Are the element of cardDeckStruct1 of type value type or reference type?
//5.	Assign cardDeckStruct2 a shallow copy of cardDeckStruct1.
//
//6.	Declare a variable, cardDeckClass1, as an array of type PlayingCardClass with 5 elements.
//      Initialize it to 5 different playing cards. Declare a variable, cardDeckClass2
//7.	Are cardDeckClass1 of type value type or reference type?
//8.	Are the element of cardDeckClass1 of type value type or reference type?
//9.	Assign cardDeckClass2 a deep copy of cardDeckClass1.

