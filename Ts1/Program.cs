using System;
using System.Linq;
using System.Collections.Generic;

namespace Ts1
{
    class Program
    {

        static void Main(string[] args)
        {
            var t = int.Parse(Console.ReadLine());
            var ans1 = new int[t];
            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine());
                var a = new List<int>(Console.ReadLine().Split().Select(x => int.Parse(x)));

                var maxInd = a.IndexOf(a.Max()) + 1;
                var minInd = a.IndexOf(a.Min()) + 1;
                var middleInd = n % 2 == 1 ? n / 2 + 1 : n / 2 + 0.5;
                var maxLen = Math.Truncate(Math.Abs(middleInd - maxInd));
                var minLen = Math.Truncate(Math.Abs(minInd - middleInd));
                var currMin = maxLen > minLen ? maxInd : minInd;
                if (currMin > middleInd)
                {
                    currMin = n - currMin + 1;
                    maxInd = n - maxInd + 1;
                    minInd = n - minInd + 1;
                }

                var ans = currMin;
                n -= ans;
                maxInd -= ans;
                minInd -= ans;
                var lastInd = maxInd == 0 ? minInd : maxInd;
                var len = Math.Min(Math.Abs(lastInd - n) + 1, lastInd);
                ans += len;

                ans1[i] = ans;
            }
            foreach(var a in ans1)
            {
                Console.WriteLine(a);
            }
        }
    }
}
