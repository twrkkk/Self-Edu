using System;

namespace Medium_LeetCode_322._Coin_Change
{
    public class Solution
    {
        public static int CoinChange(int[] coins, int amount)
        {
            int[] dp = new int[amount + 1];
            Array.Fill(dp, int.MaxValue - 1);
            dp[0] = 0;
            for (int i = 1; i <= amount; i++)
            {
                foreach (var c in coins)
                {
                    if (c <= i)
                        dp[i] = Math.Min(dp[i], 1 + dp[i - c]);
                }
            }

            return dp[amount] > amount ? -1 : dp[amount];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.CoinChange(new int[] { 1,2,5 }, 11));
        }
    }
}
