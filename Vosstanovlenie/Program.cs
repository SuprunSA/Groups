using System;
using static System.Console;
using System.Linq;
using System.Collections.Generic;

namespace Vosstanovlenie
{
    class Program
    {
        
        static void Main(string[] args)
        {
           
            var Int = new List<int>()
            {
                12,
                2312,
                1513,
                51,
                123
            };
            WriteLine(Int.Where(i => i < 2312).Max());  
        }
    }
}
