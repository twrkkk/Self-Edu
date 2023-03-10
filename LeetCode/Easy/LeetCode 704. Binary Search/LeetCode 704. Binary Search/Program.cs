using System;

namespace LeetCode_704._Binary_Search
{
    public static class Solution
    {
        public static int Search(int[] nums, int target)
        {
            int l = 0, r = nums.Length - 1, middle = -1;
            while(l<=r)
            {
                middle = l + (r - l) / 2;
                if (nums[middle] == target)
                    return middle;
                else if (nums[middle] > target)
                    r = middle - 1;
                else
                    l = middle + 1;
            }
            return -1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.Search(new[] { 5 }, 5));
        }
    }
}
