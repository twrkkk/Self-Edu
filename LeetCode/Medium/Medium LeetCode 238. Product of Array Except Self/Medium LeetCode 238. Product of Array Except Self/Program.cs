using System;

namespace Medium_LeetCode_238._Product_of_Array_Except_Self
{
    public class Solution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] left2right = new int[nums.Length];
            int[] right2left = new int[nums.Length];

            left2right[0] = 1;
            for (int i = 1; i < left2right.Length; i++)
                left2right[i] = left2right[i - 1] * nums[i - 1];

            right2left[right2left.Length - 1] = 1;
            for (int i = nums.Length - 2; i >= 0; i--)
                right2left[i] = right2left[i + 1] * nums[i + 1];

            for (int i = 0; i < left2right.Length; i++)
                left2right[i] *= right2left[i];

            return left2right;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            foreach (var item in s.ProductExceptSelf(new int[] { 1, 2, 3, 4 }))
                Console.Write($"{item} ");
            
        }
    }
}
