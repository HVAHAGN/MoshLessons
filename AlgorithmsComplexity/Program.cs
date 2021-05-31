using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsComplexity
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scrambledArray = new int[] { 6, 0, 1, 5, 15, 2, 3, 10 };

            var a = BubblySort(scrambledArray);
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        /*O(1) describes an algorithm that will always execute in the same time (or space)
         * regardless of the size of the input data set.*/
        public static bool IsFirstElementNullOrEmpty(List<string> lists)
        {
            if (lists == null)
            {
                throw new ArgumentNullException();
            }
            if (lists.Count > 0)
            {
                return true;
            }
            return false;
        }

        /*O(N) describes an algorithm whose performance will grow linearly and in direct proportion
         *   to the size of the input data set.*/
        public static bool ContainsValue(List<string> elements, string elementToBeFound)
        {
            if (elements == null)
            {
                throw new ArgumentNullException();
            }
            if (elements.Count > 0)
            {
                for (int i = 0; i < elements.Count; i++)
                {
                    if (elements[i] == elementToBeFound)
                    {
                        return true;
                    }
                }

            }
            return false;

        }

        /*O(N2) represents an algorithm whose performance is directly proportional to the square of the 
         * size of the input data set. This is common with algorithms that involve nested iterations over 
         * the data set. Deeper nested iterations will result in O(N3), O(N4) etc.*/
        public static bool ContainsDuplicate(List<string> elements)
        {
            if (elements == null)
            {
                throw new ArgumentNullException();
            }
            if (elements.Count > 0)
            {
                for (int count = 0; count < elements.Count; count++)
                {
                    for (int innerCount = 0; innerCount < elements.Count; innerCount++)
                    {
                        if (count == innerCount)
                        {
                            continue;
                        }
                        if (elements[count] == elements[innerCount])
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        /*Another classic example for same O Notation (O(N2)) is bubble sort
         The algorithm works by comparing each item in the list with the item next to it,
         and swapping them if required. In other words, the largest element has bubbled to the top of the array.*/
        public static int[] BubblySort(int[] scrambledArray)
        {
            for (int count = scrambledArray.Length - 1; count >= 0; count--)
            {
                for (int innerCount = 1; innerCount < count; innerCount++)
                {
                    if (scrambledArray[innerCount - 1] > scrambledArray[innerCount])
                    {
                        int temp = scrambledArray[innerCount - 1];
                        scrambledArray[innerCount - 1] = scrambledArray[innerCount];
                        scrambledArray[innerCount] = temp;
                    }
                }
            }
            return scrambledArray;
        }


        /*O(log n)
        An algorithm is said to take logarithmic time if T(n) = O(log n). Algorithms taking logarithmic time are commonly 
        found in operations on binary trees or when using binary search.An O(log n) algorithm is considered highly efficient,
        as the operations per instance required to complete decrease with each instance*/
        /*Binary search is one of the most basic yet very useful algorithms. It can operate on sorted arrays or range of values.*/
        public static int FindValuePostionUsingBinarySearch(List<int> numberElements, int valueToBeSearched)
        {
            if (numberElements == null)
            {
                throw new ArgumentNullException();
            }
            if (numberElements[0] > valueToBeSearched)
            {
                return -1;
            }

            int upperBound = numberElements.Count;
            int lowerBound = 0;
            while (lowerBound < upperBound)
            {
                int mid = (upperBound + lowerBound) / 2;
                if (numberElements[mid] < valueToBeSearched)
                {
                    lowerBound = mid;
                }
                else if (numberElements[mid] > valueToBeSearched)
                {
                    upperBound = mid;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }


        /*O (n log n)
       Often, good sorting algorithms are roughly O(nlogn). An example of an algorithm with this efficiency is merge sort, 
       which breaks up an array into two halves, sorts those two halves by recursively calling itself on them, and then 
       merging the result back into a single array. */

        public static int[] MergeSort(int[] inputItems, int lowerBound, int upperBound)
        {
            if (lowerBound < upperBound)
            {
                int middle = (lowerBound + upperBound) / 2;

                MergeSort(inputItems, lowerBound, middle);
                MergeSort(inputItems, middle + 1, upperBound);

                //Merge
                int[] leftArray = new int[middle - lowerBound + 1];
                int[] rightArray = new int[upperBound - middle];

                Array.Copy(inputItems, lowerBound, leftArray, 0, middle - lowerBound + 1);
                Array.Copy(inputItems, middle + 1, rightArray, 0, upperBound - middle);

                int i = 0;
                int j = 0;
                for (int count = lowerBound; count < upperBound + 1; count++)
                {
                    if (i == leftArray.Length)
                    {
                        inputItems[count] = rightArray[j];
                        j++;
                    }
                    else if (j == rightArray.Length)
                    {
                        inputItems[count] = leftArray[i];
                        i++;
                    }
                    else if (leftArray[i] <= rightArray[j])
                    {
                        inputItems[count] = leftArray[i];
                        i++;
                    }
                    else
                    {
                        inputItems[count] = rightArray[j];
                        j++;
                    }
                }
            }
            return inputItems;
        }
    }
}
