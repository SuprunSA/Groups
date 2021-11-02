using System;
using System.Linq;
using System.Collections.Generic;

namespace Friends
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = int.Parse(Console.ReadLine());
            for(int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine());
                var a = new List<int>(Console.ReadLine().Split().Select(x => int.Parse(x)));
                Console.WriteLine(Count(a));
            }
        }

        static int Count(List<int> a)
        {
            var b = a[0];
            if (a.Where(a => a == b).Count() == a.Count())
            {
                return 0;
            }
            if (a.Sum() % a.Count() != 0)
            {
                return -1;
            }
            var avg = a.Average();
            var ans = a.Where(a => a > avg).Count();
            return ans;
        }
    }
}
