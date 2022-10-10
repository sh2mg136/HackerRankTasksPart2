using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasksPart2
{
    internal class LeftRotationClass
    {
        public static List<int> rotateLeft(int d, List<int> arr)
        {
            var result = new List<int>();
            var shift = d % arr.Count;
            var ind = 0;
            for (int i = shift; i < arr.Count + shift; i++)
            {
                ind = i;
                if (ind >= arr.Count)
                    ind %= arr.Count;
                result.Add(arr[ind]);
            }
            return result;
        }
    }
}
