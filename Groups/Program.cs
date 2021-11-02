using System;
using static System.Console;

namespace Groups
{
    class Program
    {
        static void Main(string[] args)
        {
            GroupsDivision();
        }

        static string GroupsDivision()
        {
            string[] answer = { "YES", "NO" };
            ReadInput();
            return answer[0];
        }


        static int[,] ReadInput()
        {
            var count = int.Parse(ReadLine());
            int[,] input = new int[count, 5]; 
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    input[i, j] = int.Parse(ReadLine());
                }
            }
            return input;
        } 
    }
}
