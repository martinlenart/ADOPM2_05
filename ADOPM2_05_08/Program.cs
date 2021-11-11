using System;

namespace ADOPM2_05_08
{
    class Program
    {
        public class ClassPoint
        {
            public long X, Y;
        }
        static void Main(string[] args)
        {
            // Array of Reference Type
            ClassPoint[] classArr1 = { new ClassPoint { X = 3, Y = 3 }, new ClassPoint { X = 4, Y = 4 } };
            ClassPoint[] classArr2 = { new ClassPoint { X = 3, Y = 3 }, new ClassPoint { X = 4, Y = 4 } };

            // Shallow Copy of Reference types
            ClassPoint[] classCopy1 = (ClassPoint[])classArr1.Clone();
            classArr1[0].X = classArr1[0].Y = 5;
            Console.WriteLine($"\nclassCopy1[0]: X = {classCopy1[0].X}, Y = {classCopy1[0].Y}"); // 5,5 !! 
            Console.WriteLine($"classArr1[0]: X = {classArr1[0].X}, Y = {classArr1[0].Y}");      // 5,5 

            // Deep Copy of Reference types
            var classCopy2 = new ClassPoint[classArr2.Length];
            for (int i=0; i < classCopy2.Length; i++)
            {
                //Explicitly create a new element instances and copy content from original
                classCopy2[i] = new ClassPoint { X = classArr2[i].X, Y = classArr2[i].Y };
            }
            classArr2[0].X = classArr2[0].Y = 5;
            Console.WriteLine($"\nclassCopy2[0]: X = {classCopy2[0].X}, Y = {classCopy2[0].Y}"); // 3,3
            Console.WriteLine($"classArr2[0]: X = {classArr2[0].X}, Y = {classArr2[0].Y}");      // 5,5 
        }
    }
}
