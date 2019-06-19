using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public static class Formulas
    {
        public static long Factorial(int x)
        {
            long total = 1;
            for (var i = 1; i <= x; i++)
                total *= i;

            return total;
        }

        public static long Combinations(int n, int r, bool allowRepeats=false)
        {
            long p;
            if (allowRepeats)
            {
                p = Factorial(n + r - 1) / (Factorial(r) * Factorial(n - 1));
            }
            else
            {
                p = Factorial(n) / (Factorial(r) * Factorial(n - r));
            }

            return p;
        }

        public static long Permutations(int n, int r)
        {
            return Factorial(n) / Factorial(n - r);
        }

        public static List<int> Factors(int N)
        {
            var list = new List<int>();
            for (var i = 1; i <= N; i++)
            {
                var r = (N * 1.0) / (i * 1.0);
                if (Math.Floor(r) == r)
                {
                    list.Add(i);
                }
            }
            return list;
        }

        /// <summary>
        /// Calculate the Stirling number of combinations
        /// </summary>
        /// <param name="m">Number of objects</param>
        /// <param name="n">Number of buckets</param>
        public static double Stirling(int m, int n)
        {
            double result = 0;
            for (var k = 0; k < n; k++)
            {
                var a = Math.Pow(-1, k);
                var b = Combinations(n, n - k);
                var c = Math.Pow(n - k, m);

                var d = a * b * c;
                result += d;
            }

            var final = result / Factorial(n);
            return final;
        }

    }
}
