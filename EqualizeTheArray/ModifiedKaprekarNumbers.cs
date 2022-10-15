using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EqualizeTheArray
{
    internal class ModifiedKaprekarNumbersClass
    {
        public static string kaprekarNumbers(int p, int q)
        {
            List<long> k = new List<long>();

            for (int i = p; i <= q; i++)
            {
                var kaprekarNumber = Find(i);
                if (kaprekarNumber > 0)
                {
                    k.Add(kaprekarNumber);
                }
            }

            var result = String.Join(" ", k);
            if (k.Count == 0)
                result = "INVALID RANGE";
            Console.WriteLine(result);
            return result;
        }

        public static bool checkKaprekarNumbers(int p, int q)
        {
            bool hasKaprekar = false;
            List<long> k = new List<long>();

            for (int i = p; i <= q; i++)
            {
                var kaprekarNumber = Find(p);
                if (kaprekarNumber > 0)
                {
                    hasKaprekar = true;
                    k.Add(kaprekarNumber);
                }
            }

            Console.WriteLine(String.Join(" ", k));

            return hasKaprekar;
        }

        static long Find(long p)
        {
            long num = p * p;
            var len = num.ToString().Length;
            List<Tuple<int, int>> pairs = new List<Tuple<int, int>>();
            List<long> nums = new List<long>();

            if (len == 1)
            {
                nums = new List<long>() { num };
            }
            else
            {
                if (len % 2 == 0)
                {
                    pairs.Add(new Tuple<int, int>(len / 2, len / 2));
                }
                else
                {
                    int l = len / 2;
                    pairs.Add(new Tuple<int, int>(l, l + 1));
                    pairs.Add(new Tuple<int, int>(l + 1, l));
                }

                var s = num.ToString();
                StringBuilder sb = new StringBuilder();
                long a, b;
                foreach (var t in pairs)
                {
                    for (int i = 0; i < t.Item1; i++)
                        sb.Append(s[i]);
                    a = Convert.ToInt64(sb.ToString());

                    sb.Clear();
                    for (int i = t.Item1; i < t.Item1 + t.Item2; i++)
                        sb.Append(s[i]);
                    var secondStr = sb.ToString().TrimStart('0');
                    if (string.IsNullOrEmpty(secondStr))
                        b = 0;
                    else
                        b = Convert.ToInt64(secondStr);

                    if (a > 0 && b > 0)
                    {
                        nums.Add(a + b);
                    }
                }
            }

            bool result;
            foreach (var pair in nums)
            {
                result = pair == p;
                if (result)
                    return p;
            }
            return 0;
        }
    }
}
