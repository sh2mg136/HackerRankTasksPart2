namespace JumpingOnTheClouds
{
    internal class ACM_ICPC_Team_Class
    {
        public static List<int> acmTeam(List<string> topic)
        {
            var result = new List<int>();

            bool[,] arr = new bool[topic.Count, topic.First().Length];

            for (int i = 0; i < topic.Count; i++)
            {
                for (int j = 0; j < topic[i].Length; j++)
                {
                    arr[i, j] = topic[i][j] == '1' ? true : false;
                }
            }

            int maxSum = 0;
            int cnt = 1;

            Dictionary<int, int> map = new Dictionary<int, int>();

            foreach (int[] c in CombinationsFromZero(2, topic.Count))
            {
                int iii = c[0];
                int jjj = c[1];
                int sum = 0;
                for (int j = 0; j < topic[0].Length; j++)
                {
                    if (arr[c[0], j] || arr[c[1], j])
                        sum++;
                }

                if (sum > maxSum)
                    maxSum = sum;

                map.Add(cnt, sum);

                cnt++;
            }

            result.Add(maxSum);
            result.Add(map.Where(x => x.Value == maxSum).Count());
            return result;
        }

        public static IEnumerable<T[]> Combinations<T>(IEnumerable<T> source)
        {
            if (null == source)
                throw new ArgumentNullException(nameof(source));

            T[] data = source.ToArray();

            return Enumerable
              .Range(0, 1 << (data.Length))
              .Select(index => data
                 .Where((v, i) => (index & (1 << i)) != 0)
                 .ToArray());
        }

        public static IEnumerable<T[]> Combinations<T>(IEnumerable<T> source, int num)
        {
            if (null == source)
                throw new ArgumentNullException(nameof(source));

            T[] data = source.ToArray();

            return Enumerable
              .Range(0, 1 << (data.Length))
              .Select(index => data
              .Where((v, i) => (index & (1 << i)) != 0)
              .ToArray())
                .Where(x => x.Length == num);
        }

        public static List<List<T>> GetAllCombos<T>(List<T> list)
        {
            int comboCount = (int)Math.Pow(2, list.Count) - 1;
            List<List<T>> result = new List<List<T>>();
            for (int i = 1; i < comboCount + 1; i++)
            {
                // make each combo here
                result.Add(new List<T>());
                for (int j = 0; j < list.Count; j++)
                {
                    if ((i >> j) % 2 != 0)
                        result.Last().Add(list[j]);
                }
            }
            return result;
        }

        private static int countSetBits(int n)
        {
            int count = 0;
            while (n > 0)
            {
                n = n & (n - 1);
                count++;
            }
            return count;
        }

        private static bool isEven(int n)
        {
            // n^1 is n+1, then even, else odd
            if ((n ^ 1) == n + 1)
                return true;
            else
                return false;
        }

        public static IEnumerable<int[]> CombinationsA(int m, int n)
        {
            int[] result = new int[m];
            Stack<int> stack = new Stack<int>();
            stack.Push(0);

            while (stack.Count > 0)
            {
                int index = stack.Count - 1;
                int value = stack.Pop();

                while (value < n)
                {
                    result[index++] = ++value;
                    stack.Push(value);

                    if (index == m)
                    {
                        yield return result;
                        break;
                    }
                }
            }
        }

        public static IEnumerable<int[]> CombinationsFromZero(int m, int n)
        {
            int[] result = new int[m];
            Stack<int> stack = new Stack<int>();
            stack.Push(-1);

            while (stack.Count > 0)
            {
                int index = stack.Count - 1;
                int value = stack.Pop();

                while (value < n - 1)
                {
                    result[index++] = ++value;
                    stack.Push(value);

                    if (index == m)
                    {
                        yield return result;
                        break;
                    }
                }
            }
        }

        // static Tuple<int,int> comb(int total, int start)        {        }
    }
}