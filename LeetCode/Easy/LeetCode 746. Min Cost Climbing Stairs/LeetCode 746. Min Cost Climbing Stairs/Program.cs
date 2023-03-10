using System;

namespace LeetCode_746._Min_Cost_Climbing_Stairs
{
    public class Solution
    {
        public static int MinCostClimbingStairs(int[] cost)
        {
            int prev = cost[0], prevPrev = 0;
            int curr = 0;
            for (int i = 1; i < cost.Length; i++)
            {
                curr = cost[i] + Math.Min(prevPrev, prev);
                prevPrev = prev;
                prev = curr;
            }

            return Math.Min(prevPrev, curr);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.MinCostClimbingStairs(new int[] { 10, 15, 20 }));
        }
    }
}
