using System;

namespace QuickSort
{
    //Class for quicksort functions
    public class Quicksort
    {
        /// ---Sort---
        /// <summary>
        /// Main method for sort.
        /// Check if left index is smaller then right index
        /// If so it will select a pivot index
        /// And set a dividing line
        /// </summary>
        /// <param name="intArray">Array [Int] - Containing of int (Array that will be sorted)</param>
        /// <param name="leftInd">Int - Containing left index used for left side of piovet</param>
        /// <param name="rightInd">Int - Containing right index used for right side of piovet</param>
        public static void Sort(int[] intArray, int leftInd, int rightInd)
        {
            int piovetIndex;

            if (leftInd < rightInd)
            {
                piovetIndex = DividingLine(intArray, leftInd, rightInd);
                
                
            }
        }

        /// ---DividingLine---
        /// <summary>
        /// Used on line 24
        /// </summary>
        /// <param name="intArray">Array [Int] - Containing of int (Array that will be sorted)</param>
        /// <param name="leftInd">Int - Containing left index used for left side of piovet</param>
        /// <param name="rightInd">Int - Containing right index used for right side of piovet</param>
        /// <returns></returns>
        public static int DividingLine(int[] intArray, int leftInd, int rightInd)
        {
            return 1;
        }
    }

    //Main Class
    class Program
    {
        static void Main(string[] args)
        {
            //Array to be sorted
            //Array to be sorted
            int[] arr = { 4, 2, 1, 3, 5 };

            //Print out array before changes
            for(int i = 0; i < arr.Length -1; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("---------");

            //Call Quicksort (array as arr, left as 0 and right as the last index in the array)
            Quicksort.Sort(arr, 0, arr.Length - 1);

            //Print out array after changes
            for(int i = 0; i < arr.Length - 1; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
