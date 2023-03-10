using System;

namespace Medium_LeetCode_300._Longest_Increasing_Subsequence
{
    public class Solution
    {
        public int LengthOfLIS(int[] nums)
        {
            int[] len = new int[nums.Length];
            len[0] = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                int maxLen = 0;
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] > nums[j])
                        maxLen = Math.Max(maxLen, len[j]);
                }
                if (maxLen == 0)
                    len[i] = 1;
                else
                    len[i] = maxLen + 1;
            }

            int res = len[0];
            for (int i = 1; i < len.Length; i++)
                res = Math.Max(res, len[i]);

            return res;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
