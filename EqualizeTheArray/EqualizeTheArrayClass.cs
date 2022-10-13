using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualizeTheArray
{
    internal class EqualizeTheArrayClass
    {
        public static int equalizeArray(List<int> arr)
        {
            Debug.Assert(arr != null);

            /*
            var mostFrequent = arr.GroupBy(i => i)
                .GroupBy(g => g.Count())
               .OrderByDescending(g => g.Key, new MyIntComparer())
               .First()
               .Select(g => g.Key)
               .First();
            */

            var mostFrequent2 = arr.GroupBy(i => i).MaxBy(m => m.Count());
            if (mostFrequent2 == null)
                return 0;
            return arr.Where(x => x != mostFrequent2.FirstOrDefault()).Count();
        }
    }

    class MyIntComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            Console.WriteLine($"Comparing {x} with {y}");
            return x.CompareTo(y);
        }
    }
}
