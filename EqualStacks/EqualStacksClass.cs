using System.Runtime.CompilerServices;

namespace EqualStacks
{
    internal class EqualStacksClass
    {
        /// <summary>
        /// BEST SOLUTION
        /// </summary>
        /// <param name="h1"></param>
        /// <param name="h2"></param>
        /// <param name="h3"></param>
        /// <returns></returns>
        public static int equalStacks(List<int> h1, List<int> h2, List<int> h3)
        {
            int[] H = new int[3] { h1.Sum(), h2.Sum(), h3.Sum() };
            int i1 = 0, i2 = 0, i3 = 0;

            while (H[0] != H[1] || H[0] != H[2])
            {
                if (H[0] >= H[1] && H[0] >= H[2])
                    H[0] -= h1[i1++];
                else if (H[1] >= H[0] && H[1] >= H[2])
                    H[1] -= h2[i2++];
                else
                    H[2] -= h3[i3++];
            }

            return H[0];
        }


        // Assuming that we don't have cylinders of negative height
        public static int equalStacksNEW(List<int> h1, List<int> h2, List<int> h3)
        {
            if (h1.Count <= 0 || h2.Count <= 0 || h3.Count <= 0)
                return 0;

            int height1 = h1.Sum();
            int height2 = h2.Sum();
            int height3 = h3.Sum();

            int p1 = 0;
            int p2 = 0;
            int p3 = 0;

            while (height1 != height2 || height1 != height3)
            {
                if (height1 >= height2 && height1 >= height3)
                    height1 -= h1[p1++];
                else if (height2 >= height1 && height2 >= height3)
                    height2 -= h2[p2++];
                else
                    height3 -= h3[p3++];
            }

            return height1;
        }


        static int EqualStacks(int[] h1, int[] h2, int[] h3)
        {
            var a = new[] { h1, h2, h3 };
            var i = new int[3];
            var c = new int[3];
            var last = 0;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            bool GetLowest(out int result)
            {
                result = -1;
                if (c[0] <= c[1] && c[0] <= c[2] && i[0] < a[0].Length - 1) result = 0;
                else if (c[1] <= c[0] && c[1] <= c[2] && i[1] < a[1].Length - 1) result = 1;
                else if (i[2] < a[2].Length - 1) result = 2;
                else return false;
                return true;
            }

            while (true)
            {
                if (!GetLowest(out var index))
                    return last;

                c[index] += a[index][i[index]];
                i[index]++;

                if (c[0] == c[1] && c[1] == c[2])
                    last = c[0];

                // Console.WriteLine($"Current = {string.Join(", ", c)}, Index = {index}, Last = {last}");
            }

        }


        public static int equalStacks6(List<int> h1, List<int> h2, List<int> h3)
        {
            var result = 0;
            var min = Math.Min(h3.Sum(), Math.Min(h1.Sum(), h2.Sum()));

            List<int> a1 = new List<int>();
            List<int> a2 = new List<int>();
            List<int> a3 = new List<int>();

            int cnt = h1.Count - 1;
            while (result < min)
            {
                a1.Add(h1[cnt]);
                result += h1[cnt];
                cnt--;
            }

            cnt = h2.Count - 1;
            result = 0;
            while (result < min)
            {
                a2.Add(h2[cnt]);
                result += h2[cnt];
                cnt--;
            }

            cnt = h3.Count - 1;
            result = 0;
            while (result < min)
            {
                a3.Add(h3[cnt]);
                result += h3[cnt];
                cnt--;
            }

            result = 0;
            List<int> sums = new List<int>() { 0, 0, 0 };

            while (a1.Count + a2.Count + a3.Count > 0)
            {
                while (a1.Sum() > min && a1.Count > 0)
                {
                    a1.RemoveAt(a1.Count - 1);
                    if (a1.Sum() < min) min = a1.Sum();
                }

                while (a2.Sum() > min && a2.Count > 0)
                {
                    a2.RemoveAt(a2.Count - 1);
                    if (a2.Sum() < min) min = a2.Sum();
                }

                while (a3.Sum() > min && a3.Count > 0)
                {
                    a3.RemoveAt(a3.Count - 1);
                    if (a3.Sum() < min) min = a3.Sum();
                }

                if (a1.Sum() == a2.Sum() && a1.Sum() == a3.Sum())
                {
                    result = a1.Sum();
                    break;
                }
            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="h1"></param>
        /// <param name="h2"></param>
        /// <param name="h3"></param>
        /// <returns></returns>
        public static int equalStacks_CorrectButTimeout(List<int> h1, List<int> h2, List<int> h3)
        {
            var result = 0;
            var min = Math.Min(h3.Sum(), Math.Min(h1.Sum(), h2.Sum()));

            List<int> a1 = new List<int>();
            List<int> a2 = new List<int>();
            List<int> a3 = new List<int>();

            int cnt = h1.Count - 1;
            while (result < min)
            {
                a1.Add(h1[cnt]);
                result += h1[cnt];
                cnt--;
            }

            cnt = h2.Count - 1;
            result = 0;
            while (result < min)
            {
                a2.Add(h2[cnt]);
                result += h2[cnt];
                cnt--;
            }

            cnt = h3.Count - 1;
            result = 0;
            while (result < min)
            {
                a3.Add(h3[cnt]);
                result += h3[cnt];
                cnt--;
            }

            result = 0;
            List<int> sums = new List<int>() { 0, 0, 0 };
            Stack<int> s0 = new Stack<int>(a1);
            Stack<int> s1 = new Stack<int>(a2);
            Stack<int> s2 = new Stack<int>(a3);

            // var max = Math.Max(a3.Count, Math.Max(a1.Count, a2.Count));

            while (s0.Count + s1.Count + s2.Count > 0)
            {
                while (s0.Sum() > min && s0.Count > 0)
                {
                    s0.Pop();
                    if (s0.Sum() < min) min = s0.Sum();
                }

                while (s1.Sum() > min && s1.Count > 0)
                {
                    s1.Pop();
                    if (s1.Sum() < min) min = s1.Sum();
                }

                while (s2.Sum() > min && s2.Count > 0)
                {
                    s2.Pop();
                    if (s2.Sum() < min) min = s2.Sum();
                }

                if (s0.Sum() == s1.Sum() && s0.Sum() == s2.Sum())
                {
                    result = s0.Sum();
                    break;
                }
            }
            return result;
        }

        public static int equalStacks5(List<int> h1, List<int> h2, List<int> h3)
        {
            var result = 0;

            var max = Math.Max(h3.Count, Math.Max(h1.Count, h2.Count));
            var min = Math.Min(h3.Sum(), Math.Min(h1.Sum(), h2.Sum()));

            List<int> a1 = new List<int>();
            List<int> a2 = new List<int>();
            List<int> a3 = new List<int>();

            int cnt = h1.Count - 1;
            while (result < min)
            {
                a1.Add(h1[cnt]);
                result += h1[cnt];
                cnt--;
            }

            cnt = h2.Count - 1;
            result = 0;
            while (result < min)
            {
                a2.Add(h2[cnt]);
                result += h2[cnt];
                cnt--;
            }

            cnt = h3.Count - 1;
            result = 0;
            while (result < min)
            {
                a3.Add(h3[cnt]);
                result += h3[cnt];
                cnt--;
            }

            result = 0;
            List<int> sums = new List<int>() { 0, 0, 0 };
            Stack<int> s0 = new Stack<int>(a1);
            Stack<int> s1 = new Stack<int>(a2);
            Stack<int> s2 = new Stack<int>(a3);

            for (int i = 0; i < max; i++)
            {
                while (s0.Sum() > min && s0.Count > 0)
                {
                    s0.Pop();
                    if (s0.Sum() < min) min = s0.Sum();
                }

                while (s1.Sum() > min && s1.Count > 0)
                {
                    s1.Pop();
                    if (s1.Sum() < min) min = s1.Sum();
                }

                while (s2.Sum() > min && s2.Count > 0)
                {
                    s2.Pop();
                    if (s2.Sum() < min) min = s2.Sum();
                }

                if (s0.Sum() == s1.Sum() && s0.Sum() == s2.Sum())
                {
                    result = s0.Sum();
                    break;
                }
            }
            return result;
        }

        public static int equalStacks4(List<int> h1, List<int> h2, List<int> h3)
        {
            var result = 0;

            var max = Math.Max(h3.Count, Math.Max(h1.Count, h2.Count));
            var min = Math.Min(h3.Sum(), Math.Min(h1.Sum(), h2.Sum()));

            h1.Reverse();
            h2.Reverse();
            h3.Reverse();

            List<int> a1 = new List<int>();
            List<int> a2 = new List<int>();
            List<int> a3 = new List<int>();
            int cnt = 0;
            while (result < min)
            {
                a1.Add(h1[cnt]);
                result += h1[cnt];
                cnt++;
            }

            cnt = 0;
            result = 0;
            while (result < min)
            {
                a2.Add(h2[cnt]);
                result += h2[cnt];
                cnt++;
            }

            cnt = 0;
            result = 0;
            while (result < min)
            {
                a3.Add(h3[cnt]);
                result += h3[cnt];
                cnt++;
            }

            result = 0;
            List<int> sums = new List<int>() { 0, 0, 0 };
            Stack<int> s0 = new Stack<int>(a1);
            Stack<int> s1 = new Stack<int>(a2);
            Stack<int> s2 = new Stack<int>(a3);

            for (int i = 0; i < max; i++)
            {
                while (s0.Sum() > min && s0.Count > 0)
                {
                    s0.Pop();
                    if (s0.Sum() < min) min = s0.Sum();
                }

                while (s1.Sum() > min && s1.Count > 0)
                {
                    s1.Pop();
                    if (s1.Sum() < min) min = s1.Sum();
                }

                while (s2.Sum() > min && s2.Count > 0)
                {
                    s2.Pop();
                    if (s2.Sum() < min) min = s2.Sum();
                }

                if (s0.Sum() == s1.Sum() && s0.Sum() == s2.Sum())
                {
                    result = s0.Sum();
                    break;
                }
            }
            return result;
        }

        public static int equalStacks3(List<int> h1, List<int> h2, List<int> h3)
        {
            var result = 0;
            List<int> sums = new List<int>() { 0, 0, 0 };

            Stack<int> s0 = new Stack<int>(h1);
            Stack<int> s1 = new Stack<int>(h2);
            Stack<int> s2 = new Stack<int>(h3);

            var level = 1;
            int cnt = 0;

            while (cnt <= s0.Count)
            {
                if (sums[0] < level && s0.Count > 0)
                {
                    while (sums[0] < level && s0.Count > 0)
                    {
                        sums[0] += s0.Pop();
                        if (sums[0] > level)
                            level = sums[0];
                    }
                }

                if (sums[1] < level && s1.Count > 0)
                {
                    while (sums[1] < level && s1.Count > 0)
                    {
                        sums[1] += s1.Pop();
                        if (sums[1] > level)
                            level = sums[1];
                    }
                }

                if (sums[2] < level && s2.Count > 0)
                {
                    while (sums[2] < level && s2.Count > 0)
                    {
                        sums[2] += s2.Pop();
                        if (sums[2] > level)
                            level = sums[2];
                    }
                }

                cnt++;

                if (sums[0] == sums[1] && sums[0] == sums[2])
                    result = sums[0];
            }

            return result;
        }

        public static int equalStacks2(List<int> h1, List<int> h2, List<int> h3)
        {
            var result = 0;
            List<int> tallest = h1;
            List<int> a2 = h2;
            List<int> a3 = h3;
            if (h2.Sum() > h1.Sum())
            {
                tallest = h2;
                a2 = h1;
                a3 = h3;
            }
            if (h3.Sum() > h2.Sum())
            {
                tallest = h3;
                a2 = h1;
                a3 = h2;
            }
            var maxHeight = tallest.Sum();
            int cnt = 1;
            int tmp = 0;
            while (cnt <= tallest.Count)
            {
                tmp += tallest[tallest.Count - cnt];
                var b1 = probe(a2, tmp);
                var b2 = probe(a3, tmp);
                if (b1 && b2)
                    result = tmp;
                cnt++;
            }
            return result;
        }

        private static bool probe(List<int> arr, int val)
        {
            var sum = 0;
            for (int i = arr.Count - 1; i >= 0; i--)
            {
                sum += arr[i];
                if (sum == val)
                    return true;
            }
            return false;
        }
    }
}