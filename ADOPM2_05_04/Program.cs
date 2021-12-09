using System;

namespace ADOPM2_05_04
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            char secondToLast = vowels[^2];    // 'o'

            Index first = 0;
            Index last = ^1;
            char firstElement = vowels[first]; // 'a'
            char lastElement = vowels[last];   // 'u'

            char[] slice1 = vowels[..2];     // 'a', 'e'
            char[] slice2 = vowels[2..];    // 'i', 'o', 'u'
            char[] slice3 = vowels[2..4];   // 'i', 'o'
            char[] slice4 = vowels[..^2];     // 'o', 'u'

            Range firstTwoRange = 0..2;
            char[] slice5 = vowels[firstTwoRange]; // 'a', 'e'

            Console.WriteLine(lastElement);  // u
            Console.WriteLine(slice4);       // ou
            Console.WriteLine(slice3);       // i

            string slicetest = @"there was ""quote""";
            string substring = slicetest[4..];
            Console.WriteLine(substring);
        }
    }
}

//Exercises
//1.    Create a string variable and initiate it with the value:
//      "There was an Old Man with a beard. Who said, "It is just as I feared!"
//      - Remember Verbatim string for easy insertion of quotation mark
//      - use slicing to create a substring containing: 
//      Old Man with a beard.Who said, "It is just as I feared!"
//      - use slicing to create a substring containing: 
//      "It is just as I feared!"



