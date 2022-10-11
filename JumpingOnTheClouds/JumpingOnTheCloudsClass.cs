using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingOnTheClouds
{
    internal class JumpingOnTheCloudsClass
    {
        public static int jumpingOnClouds(List<int> c)
        {
            int result = 0;
            int cnt = 0;
            while (cnt < c.Count - 1)
            {
                if (cnt + 2 < c.Count && c[cnt + 2] == 0)
                    cnt ++;
                result++;
                cnt++;
            }
            return result;
        }
    }
}
