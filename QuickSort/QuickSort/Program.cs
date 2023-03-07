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
            //Will be filled with return value of DividingLine
            int piovetIndex;

            if (leftInd < rightInd)
            {
                //piovetIndex will be value of first index after DividingLine returned
                piovetIndex = DividingLine(intArray, leftInd, rightInd);

                //Sort with one piovetIndex
                Sort(intArray, leftInd, piovetIndex - 1);

                //Sort with two piovetIndex
                Sort(intArray, piovetIndex + 1, rightInd);
            }
        }
        /// ---DividingLine---
        /// <summary>
        /// Helper for Sort (Used on line 37)
        /// 
        /// </summary>
        /// <param name="intArray">Array [Int] - Containing of int (Array that will be sorted)</param>
        /// <param name="leftInd">Int - Containing left index used for left side of piovet</param>
        /// <param name="rightInd">Int - Containing right index used for right side of piovet</param>
        /// <returns>Index + 1</returns>
        public static int DividingLine(int[] intArray, int leftInd, int rightInd)
        {
            //Variables 
            int index;
            int piovet;
            int savedValue;
            int savedValueTwo;

            //Set piovet as last value in the array
            piovet = intArray[rightInd];
            //Set index as first index in the array
            index = leftInd -1;

            //Loop as long as right is bigger then left
            for (int i = leftInd; i < rightInd; i++)
            {
                //if array value is smaller then arrays last value swap values
                if (intArray[i] < piovet)
                {
                    index++;
                    //--Swapping values--//
                    savedValue = intArray[index];
                    intArray[index] = intArray[i];
                    intArray[i] = savedValue;
                }
            }
            ////Before (4, 2, 1, 3, 5) after (3, 4, 1, 2, 5)

            //--Swapping values--//
            savedValueTwo = intArray[index + 1];
            intArray[index + 1] = intArray[rightInd];
            intArray[rightInd] = savedValueTwo;
            //Before (3, 4, 1, 2, 5) after (3, 5, 1, 2, 4)

            //Return
            return index + 1;
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
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("---------");

            //Call Quicksort (array as arr, left as 0 and right as the last index in the array)
            Quicksort.Sort(arr, 0, arr.Length - 1);

            //Print out array after changes
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
