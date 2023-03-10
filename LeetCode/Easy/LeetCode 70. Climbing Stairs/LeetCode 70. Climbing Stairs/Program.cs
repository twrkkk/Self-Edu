using System;

namespace LeetCode_70._Climbing_Stairs
{
    class Program
    {
        public class Solution
        {
            public static int ClimbStairs(int n)
            {
                if (n < 2) return 1;
                int prev = 1, prevPrev = 1;
                int cur = 1;
                for (int i = 2; i <= n; i++)
                {
                    cur = prev + prevPrev;
                    prevPrev = prev;
                    prev = cur;
                }

                return cur;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.ClimbStairs(2));
        }
    }
}
