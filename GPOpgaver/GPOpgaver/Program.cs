using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace GPOpgaver
{
    class Program
    {

        static void Main(string[] args)
        {
            //Opgave 1 Interchange
            int x = 1, y = 2 ;
            Console.WriteLine("opgave Interchange before change: " + x + " " + y );
            Opgaver.Interchange(ref x, ref y);
            Console.WriteLine("opgave Interchange after change: " + x + " " + y );

            //Opgave 2 InterchangeTriple
            int newX = 1, newY = 2, newZ = 4;
            Console.WriteLine("opgave InterchangeTriple before change: " + newX + " " + newY + " " + newZ );
            Opgaver.InterchangeTriple(ref newX, ref newY, ref newZ);
            Console.WriteLine("opgave InterchangeTriple after change: " + newX + " " + newY + " " + newZ);

            //Opgave 3 IsPalindrome
            Console.WriteLine("opgave IsPalindrome: " + Opgaver.IsPalindrome("norddron"));
            Console.WriteLine("opgave IsPalindrome: " + Opgaver.IsPalindrome("Hello"));

            //Opgave 4 StepsInLinearSearch
            int searchFor = 9;
            int[] array = { 1, 3, 4, 5, 6, 8, 9, 11};
            Console.WriteLine("opgave StepsInLinearSearch: " + Opgaver.StepsInLinearSearch(searchFor, array));

            //Opgave 5 StepsInBinarySearch
            int newSearchFor = 9;
            int[] newArray = { 1, 3, 4, 5, 6, 8, 9, 11 };
            int arrayStart = 0;
            int arrayEnd = newArray.Length - 1;
            Console.WriteLine("opgave StepsInBinarySearch: " + Opgaver.StepsInBinarySearch(newArray, arrayStart, arrayEnd, newSearchFor));

            //Opgave 6 InsertSortedList
            List<int> aList = new List<int> { 1, 2, 3, 5, 6, 8, 9 };
            int newInsertList = 4;
            Console.WriteLine("opgave InsertSortedList: " + Opgaver.InsertSortedList(aList, newInsertList));


        }
    }
}
