using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasksPart2
{
    internal class CavityMapClass
    {
        public static List<string> cavityMap(List<string> grid)
        {
            var result = new List<string>();
            var len = grid.Count;
            var data = new int[len, len];

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    var ch = grid[i][j];
                    data[i, j] = Convert.ToInt32(ch.ToString());
                }
            }

            List<Tuple<int, int>> coords = new List<Tuple<int, int>>();

            for (int i = 1; i < len - 1; i++)
            {
                for (int j = 1; j < len - 1; j++)
                {
                    var check = data[i, j];
                    if (data[i - 1, j] < check && data[i + 1, j] < check && data[i, j - 1] < check && data[i, j + 1] < check)
                        coords.Add(new Tuple<int, int>(i, j));
                }
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < len; i++)
            {
                sb = new StringBuilder();
                for (int j = 0; j < len; j++)
                {
                    if (coords.Exists(x=>x.Item1==i && x.Item2==j))
                        sb.Append('X');
                    else
                        sb.Append(grid[i][j]);
                }
                result.Add(sb.ToString());
            }

            return result;
        }
    }
}
