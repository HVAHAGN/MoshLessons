using System;
using System.Collections.Generic;
using System.Linq;

namespace Extensions
{
    public static class Extensions
    {
        public static string Shorten(this String str, int numberOfWords)
        {
            if (numberOfWords < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (numberOfWords == 0)
            {
                return "";
            }
            var words = str.Split(' ');
            if (words.Length <= numberOfWords)
            {
                return str;
            }
            return string.Join(" ", words.Take(numberOfWords));
        }
        public static int GetMax(this List<int> numbers)
        {
            if (numbers.Count==0 || numbers==null)
            {
                throw new ArgumentNullException();
            }
            var max = numbers.Max();
            return max;
        }
    }

}
