using System.Numerics;

namespace ExtraLongFactorials
{
    internal class ExtraLongFactorialsClass
    {
        public static string Run(int n)
        {
            if (n <= 20)
            {
                var res = fact(n);
                return res.ToString();
            }
            else
            {
                BigInteger b = longfact(n);
                return b.ToString();
            }
        }

        private static long fact(int i)
        {
            if (i <= 1) return 1;
            long result = 0;
            result += i * fact(i - 1);
            return result;
        }

        private static BigInteger longfact(int n)
        {
            if (n <= 1) return 1;
            BigInteger b = BigInteger.One;
            for (int i = 2; i <= n; i++)
            {
                b = BigInteger.Multiply(new BigInteger(i), b);
            }
            return b;
        }
    }
}