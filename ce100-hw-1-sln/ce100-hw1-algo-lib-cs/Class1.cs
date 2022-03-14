using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ce100_hw1_algo_lib_cs
{

    /**
  * @file CE100-hw1-algo-lib-cs
  * @author Ömer Polat
  * @date 14 March 2022
  *
  * @brief <b> HW-1 Functions </b>
  *
  * HW-1 Sample Lib Functions
  *
  * @see http://bilgisayar.mmf.erdogan.edu.tr/en/
  *
  */



    public class Class1
    {


        /**
*
*	  @name   Insertion Sort (ce100_fibonacciNumber)
*
*	  @brief Insertion Sort Algorithm
*
*	  Insertion sort is a simple sorting algorithm that works similar to the way you sort playing cards in your hands. The array is virtually split into a sorted and an unsorted part. Values from the unsorted part are picked and placed at the correct position in the sorted part.
*
*	  
**/
        public static void InsSort(int[] mass)
        {
            for (int i = 1; i < mass.Length; i++)
            {
                int cur = mass[i];
                int j = i;

                // Move elements of arr[0..i-1],
                // that are greater than key,
                // to one position ahead of
                // their current position

                while (j > 0 && cur < mass[j - 1])
                {
                    mass[j] = mass[j - 1];
                    j--;
                }
                mass[j] = cur;
            }
        }


        

        /**
*
*	  @name   Selection Sort 
*
*	  @brief Selection Sort Algorithm
*
*	  The selection sort algorithm sorts an array by repeatedly finding the minimum element (considering ascending order) from unsorted part and putting it at the beginning. The algorithm maintains two subarrays in a given array.
*     1) The subarray which is already sorted. 
*     2) Remaining subarray which is unsorted.
*     In every iteration of selection sort, the minimum element (considering ascending order) from the unsorted subarray is picked and moved to the sorted subarray. 
*
*
*	  
**/

        public static int[] SortArray(int[] numArray, int arrayLength)
        {
            int tempVar, smallestVal;

            // One by one move boundary of unsorted subarray
            for (int i = 0; i < arrayLength - 1; i++)
            {
                // Find the minimum element in unsorted array
                smallestVal = i;
                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (numArray[j] < numArray[smallestVal])
                    {
                        smallestVal = j;
                    }
                }
                // Swap the found minimum element with the first
                // element
                tempVar = numArray[smallestVal];
                numArray[smallestVal] = numArray[i];
                numArray[i] = tempVar;
            }
            return numArray;
        }




        /**
*
*	  @name   Recursive Power 
*
*	  @brief Recursive Power Algorithm
*     
*     A recursive (recursive or recursive) function can be expressed as a function calling itself. In other words, they can be called self-invoking functions.
*	  
**/
        public static int CalcuOfPower(int x, int y)
        {
            if (y == 0)
                return 1;
            else
                return x * CalcuOfPower(x, y - 1);
        }



        /**
*
*	  @name   Naive Power 
*
*	  @brief Naive Power Algorithm
*     
*     The array is virtually split into a sorted and an unsorted part. Values from the unsorted part are picked and placed at the correct position in the sorted part.
*     
*	  
**/
        public static int Naivepower(int x, int y)
        {
            int pow = 1;

            for (int i = 1; i <= y; i++)
            {
                pow = pow * x;
            }

            return pow;
        }



        /**
        *
        *	  @name   Binary Search Recursive
        *
        *	  @brief Binary Search Recursive Algorithm
        *     
        *     Recursive Binary Search implementations using Binary Tree in C#. This is a Divide-and-Conquer search algorithm that works on a sorted array. 
        *     Demonstrate Binary search using Recursion in Binary Tree.
        *	  
        **/

        public static int BinarySearchRecursive(int[] inputArray, int min, int max, int key)
        {


            int mid = min + (max-min) / 2;

            // If the element is present at the middle itself
            if (key == inputArray[mid])
            {
                return mid;
            }
            // If element is smaller than mid, then it can only be present in left subarray
            else if (key < inputArray[mid])
            {
                return BinarySearchRecursive(inputArray, min, mid - 1, key);
            }
            // Else the element can only be present in right subarray
            else
            {
                return BinarySearchRecursive(inputArray, mid + 1, max, key);
            }

        }


        
        /**
        *
        *	  @name   Binary Search Iterative
        *
        *	  @brief Binary Search Iterative Algorithm
        *     
        *     Iterative implementation of the binary search algorithm to return the position of `target` in array `nums` of size `n`
        *	  
        **/
        

        public static int BinarySearchIterative(int[] inputArray, int key)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                // Check if x is present at mid
                if (key == inputArray[mid])
                {
                    return mid;
                }
                // If x is smaller, ignore right half
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                // If x greater, ignore left half
                else
                {
                    min = mid + 1;
                }
            }
            // if we reach here, then element was
            // not present
            return -1;
        }



        /**
*
*	  @name   Merge Sort 
*
*	  @brief Merge Sort Algorithm
*
*	   It divides the input array into two halves, calls itself for the two halves, and then merges the two sorted halves.The merge() function is used for merging two halves.
*	   The merge(arr, left, m, right) is a key process that assumes that arr[l..m] and arr[m + 1..r] are sorted and merges the two sorted sub-arrays into one.
*
*
*	  
**/
        public static int[] mergeSort(int[] array)
        {
            int[] left;
            int[] right;
            int[] result = new int[array.Length];
            //As this is a recursive algorithm, we need to have a base case to 
            //avoid an infinite recursion and therfore a stackoverflow
            if (array.Length <= 1)
                return array;
            // The exact midpoint of our array  
            int midPoint = array.Length / 2;
            //Will represent our 'left' array
            left = new int[midPoint];

            //if array has an even number of elements, the left and right array will have the same number of 
            //elements
            if (array.Length % 2 == 0)
                right = new int[midPoint];
            //if array has an odd number of elements, the right array will have one more element than left
            else
                right = new int[midPoint + 1];
            //populate left array
            for (int i = 0; i < midPoint; i++)
                left[i] = array[i];
            //populate right array   
            int x = 0;
            //We start our index from the midpoint, as we have already populated the left array from 0 to 

            for (int i = midPoint; i < array.Length; i++)
            {
                right[x] = array[i];
                x++;
            }
            //Recursively sort the left array
            left = mergeSort(left);
            //Recursively sort the right array
            right = mergeSort(right);
            //Merge our two sorted arrays
            result = merge(left, right);
            return result;
        }

        //This method will be responsible for combining our two sorted arrays into one giant array
        public static int[] merge(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];
            //
            int indexLeft = 0, indexRight = 0, indexResult = 0;
            //while either array still has an element
            while (indexLeft < left.Length || indexRight < right.Length)
            {
                //if both arrays have elements  
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    //If item on left array is less than item on right array, add that item to the result array 
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    // else the item in the right array wll be added to the results array
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                //if only the left array still has elements, add all its items to the results array
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                //if only the right array still has elements, add all its items to the results array
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            return result;
        }

    }
}
