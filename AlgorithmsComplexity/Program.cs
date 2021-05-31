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
            if (elements==null)
            {
                throw new ArgumentNullException();
            }
            if (elements.Count>0)
            {
                for (int count = 0; count < elements.Count; count++)
                {
                    for (int innerCount = 0; innerCount < elements.Count; innerCount++)
                    {
                        if (count==innerCount)
                        {
                            continue;
                        }
                        if (elements[count]==elements[innerCount])
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
