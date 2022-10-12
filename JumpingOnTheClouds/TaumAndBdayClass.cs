using System.Numerics;

namespace JumpingOnTheClouds
{
    internal class TaumAndBdayClass
    {
        /// <summary>
        /// Всего существует два типа подарков, которые Дикша хочет получить от Таума: чёрный и белый.
        /// Для того чтобы Дикша была счастлива, Таум должен купить  чёрных и  белых подарков.
        /// Стоимость каждого чёрного подарка  X  единиц.
        /// Стоимость каждого белого подарка   Y  единиц.
        /// Стоимость обмена каждого белого подарка на чёрный или чёрного на белый  Z  единиц.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="w"></param>
        /// <param name="bc"></param>
        /// <param name="wc"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        public static long Run(int b, int w, int bc, int wc, int z)
        {
            List<long> p = new List<long>();
            p.Add(b * bc + w * wc);
            p.Add(b * wc + b * z + w * wc);
            p.Add(w * bc + w * z + b * bc);

            BigInteger B = new BigInteger(b);
            BigInteger W = new BigInteger(w);
            BigInteger BC = new BigInteger(bc);
            BigInteger WC = new BigInteger(wc);
            BigInteger Z = new BigInteger(z);

            BigInteger v1 = BigInteger.Multiply(B, BC);
            v1 = BigInteger.Add(v1, BigInteger.Multiply(W, WC));

            BigInteger v2 = BigInteger.Multiply(B, WC);
            v2 = BigInteger.Add(v2, BigInteger.Multiply(B, Z));
            v2 = BigInteger.Add(v2, BigInteger.Multiply(W, WC));

            BigInteger v3 = BigInteger.Multiply(W, BC);
            v3 = BigInteger.Add(v3, BigInteger.Multiply(W, Z));
            v3 = BigInteger.Add(v3, BigInteger.Multiply(B, BC));

            List<BigInteger> A = new List<BigInteger>();
            A.Add(v1);
            A.Add(v2);
            A.Add(v3);

            var M = A.Min();
            Console.WriteLine(M.ToString());
            return (long)M;
        }
    }
}