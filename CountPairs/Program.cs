using System;
using System.Linq;
using System.Collections.Generic;

namespace CountPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                var n = new List<long>(Console.ReadLine().Split().Select(x => long.Parse(x)));
                var a = new List<long>(Console.ReadLine().Split().Select(x => long.Parse(x)));
                a.Sort();
                try
                {
                    Console.WriteLine(Count(a, n[1], n[2], (int)n[0]));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.TargetSite);
                    Console.WriteLine(string.Format("{0} \t {1} \t {2}", n[0], n[1], n[2]));
                }
            }
        }

        static long Count(List<long> a, long l, long r, int n)
        {
            long fst = a[0];
            long snd = a[1];
            long lst = a[n - 1];
            long lst1 = a[n - 2];
            long ans = 0;

            if (fst + snd > r || lst + lst1 < l)
            {
                return ans;
            }

            for (int j = 0; j < n; j++)
            {
                ans += Check(a, j, l, r);
            }

            return ans / 2;
        }

        static long Check(List<long> a, int j, long l, long r)
        {
            long b = a[j] - l;
            long c = a[j] - r;
            long excess = 0;
            if (a[j] * 2 >= l && a[j] * 2 <= r)
            {
                excess = 1;
            }
            return a.Count(a => a + b >= 0 && a + c <= 0) - excess;
        }
    }
}