using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasksPart2
{
    internal class SparseArraysClass
    {
        public static List<int> matchingStrings(List<string> stringList, List<string> queries)
        {
            var result = new List<int>();
            int c = 0;
            foreach (var str in queries)
            {
                c = stringList.Where(x => x == str).Count();
                result.Add(c);
            }
            return result;
        }
    }
}
