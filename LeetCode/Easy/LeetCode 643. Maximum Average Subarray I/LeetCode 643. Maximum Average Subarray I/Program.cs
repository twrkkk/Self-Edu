using System;

namespace LeetCode_643._Maximum_Average_Subarray_I
{
    public class Solution
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            for (int i = 1; i < nums.Length; i++)
                nums[i] += nums[i - 1];
            int maxSum = nums[k-1];
            for (int i = k; i < nums.Length; i++)
                maxSum = Math.Max(maxSum, nums[i] - nums[i - k]);
            return (double)maxSum / k;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
